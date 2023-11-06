using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;

namespace Food_and_Beverage
{
    public partial class BeverageControl : UserControl
    {
        private List<Drink> _beverageList;
        public class SavedBeverage
        {
            public string Name { get; set; }
            public string ImageUrl { get; set; }
            public List<string> Ingredients { get; set; } = new List<string>();
            public string Instructions { get; set; }
        }
        public BeverageControl()
        {
            InitializeComponent();
            Load_Beverages();
            BeveragesListBox.SelectedIndexChanged += BeveragesListBox_SelectedIndexChanged;
        }

        private void Load_Beverages()
        {
            var client = new RestClient("https://www.thecocktaildb.com/api/json/v1/1/search.php?s");
            var request = new RestRequest();
            var response = client.Execute(request);
            Rootobject_Beverage beverageRootObject = JsonSerializer.Deserialize<Rootobject_Beverage>(response.Content);

            _beverageList = beverageRootObject?.drinks.ToList() ?? new List<Drink>();

            foreach (var beverage in _beverageList)
            {
                BeveragesListBox.Items.Add(beverage.strDrink);
            }
        }

        private void BeveragesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ingredientsListBox.Items.Clear();

            if (BeveragesListBox.SelectedIndex != -1)
            {
                var selectedBeverage = _beverageList[BeveragesListBox.SelectedIndex];

                beveragePictureBox.Load(selectedBeverage.strDrinkThumb); 
                instructionTextBox.Text = selectedBeverage.strInstructions;

                var ingredients = new StringBuilder();
                for (int i = 1; i <= 15; i++) 
                {
                    var ingredientProp = selectedBeverage.GetType().GetProperty($"strIngredient{i}");
                    var ingredient = (string)ingredientProp?.GetValue(selectedBeverage);
                    if (!string.IsNullOrWhiteSpace(ingredient))
                    {
                        ingredientsListBox.Items.Add(ingredient);
                    }
                }
            }
        }

        private const string savedBeveragesFilePath = "savedBeverages.json"; // Ensure this is the correct path

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (BeveragesListBox.SelectedIndex != -1)
            {
                var selectedBeverage = _beverageList[BeveragesListBox.SelectedIndex];

                // Create a new SavedBeverage object from the selected beverage
                var savedBeverage = new SavedBeverage
                {
                    Name = selectedBeverage.strDrink,
                    ImageUrl = selectedBeverage.strDrinkThumb,
                    Ingredients = GetIngredients(selectedBeverage),
                    Instructions = selectedBeverage.strInstructions
                };

                // Load existing beverages from file
                var savedBeverages = LoadBeveragesFromFile();

                // Add the new beverage
                savedBeverages.Add(savedBeverage);

                // Serialize the updated list to JSON
                var json = JsonSerializer.Serialize(savedBeverages, new JsonSerializerOptions { WriteIndented = true });

                // Write the JSON back to the file
                File.WriteAllText(savedBeveragesFilePath, json);
            }
        }

        private List<string> GetIngredients(Drink drink)
        {
            var ingredients = new List<string>();
            for (int i = 1; i <= 15; i++)
            {
                var ingredientProp = drink.GetType().GetProperty($"strIngredient{i}");
                var ingredient = (string)ingredientProp?.GetValue(drink);
                if (!string.IsNullOrWhiteSpace(ingredient))
                {
                    ingredients.Add(ingredient);
                }
            }
            return ingredients;
        }

        private List<SavedBeverage> LoadBeveragesFromFile()
        {
            // If the file exists, read it and deserialize the content.
            // Otherwise, just return a new list.
            if (File.Exists(savedBeveragesFilePath))
            {
                string json = File.ReadAllText(savedBeveragesFilePath);
                return JsonSerializer.Deserialize<List<SavedBeverage>>(json) ?? new List<SavedBeverage>();
            }
            return new List<SavedBeverage>();
        }
    }
}
