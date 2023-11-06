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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveSelectedBeverage();
        }

        private void SaveSelectedBeverage()
        {
            if (BeveragesListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a recipe first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedBeverage = _beverageList[BeveragesListBox.SelectedIndex];

            var savedBeverage = new SavedBeverage
            {
                Name = selectedBeverage.strDrink,
                ImageUrl = selectedBeverage.strDrinkThumb,
                Instructions = selectedBeverage.strInstructions
            };

            for (int i = 1; i <= 15; i++)
            {
                var ingredientProp = selectedBeverage.GetType().GetProperty($"strIngredient{i}");
                var ingredient = (string)ingredientProp?.GetValue(selectedBeverage);
                if (!string.IsNullOrWhiteSpace(ingredient))
                {
                    savedBeverage.Ingredients.Add(ingredient);
                }
            }

            string filePath = "C:\\Y4\\Soa\\CA1\\Food and Beverage\\savedBeverages.json"; // Copy your full path here

            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "[]");
            }

            string existingJson = File.ReadAllText(filePath);
            var beverageList = JsonSerializer.Deserialize<List<SavedBeverage>>(existingJson) ?? new List<SavedBeverage>();

            if (beverageList.Any(b => b.Name == savedBeverage.Name))
            {
                MessageBox.Show("This recipe is already saved.", "Duplicate Recipe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                beverageList.Add(savedBeverage);

                string updatedJson = JsonSerializer.Serialize(beverageList, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, updatedJson);

                MessageBox.Show("Recipe saved successfully.", "Recipe Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
