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
    public partial class MealControl : UserControl
    {
        private List<Meal> _mealList;
        public class SavedMeal
        {
            public string Name { get; set; }
            public string ImageUrl { get; set; }
            public List<string> Ingredients { get; set; } = new List<string>();
            public string Instructions { get; set; }
        }
        public MealControl()
        {
            InitializeComponent();
            Load_Food();
            FoodListBox.SelectedIndexChanged += FoodListBox_SelectedIndexChanged;
        }

        private void Load_Food()
        {
            var client = new RestClient("https://www.themealdb.com/api/json/v1/1/search.php?s");
            var request = new RestRequest();
            var response = client.Execute(request);
            var foodRootObject = JsonSerializer.Deserialize<Rootobject_Food>(response.Content);

            _mealList = foodRootObject?.meals.ToList() ?? new List<Meal>();

            foreach (var meal in _mealList)
            {
                FoodListBox.Items.Add(meal.strMeal);
            }
        }

        private void FoodListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ingredientsListBox.Items.Clear();

            if (FoodListBox.SelectedIndex != -1)
            {
                var selectedMeal = _mealList[FoodListBox.SelectedIndex];

                mealPictureBox.Load(selectedMeal.strMealThumb);
                instructionTextBox.Text = selectedMeal.strInstructions;

                var ingredients = new StringBuilder();
                for (int i = 1; i <= 20; i++)
                {
                    var ingredientProp = selectedMeal.GetType().GetProperty($"strIngredient{i}");
                    var ingredient = (string)ingredientProp?.GetValue(selectedMeal);
                    if (!string.IsNullOrWhiteSpace(ingredient))
                    {
                        ingredientsListBox.Items.Add(ingredient);
                    }
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveSelectedMeal();
        }

        private void SaveSelectedMeal()
        {
            if (FoodListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a recipe first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedMeal = _mealList[FoodListBox.SelectedIndex];

            var savedMeal = new SavedMeal
            {
                Name = selectedMeal.strMeal,
                ImageUrl = selectedMeal.strMealThumb,
                Instructions = selectedMeal.strInstructions
            };

            for (int i = 1; i <= 20; i++)
            {
                var ingredientProp = selectedMeal.GetType().GetProperty($"strIngredient{i}");
                var ingredient = (string)ingredientProp?.GetValue(selectedMeal);
                if (!string.IsNullOrWhiteSpace(ingredient))
                {
                    savedMeal.Ingredients.Add(ingredient);
                }
            }

            string filePath = "C:\\Y4\\Soa\\CA1\\Food and Beverage\\savedMeals.json"; // Copy your full path here

            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "[]");
            }

            // Read the existing JSON array from the file and deserialize it.
            string existingJson = File.ReadAllText(filePath);
            var mealList = JsonSerializer.Deserialize<List<SavedMeal>>(existingJson) ?? new List<SavedMeal>();

            // Check if the meal is already saved.
            if (mealList.Any(m => m.Name == savedMeal.Name))
            {
                MessageBox.Show("This recipe is already saved.", "Duplicate Recipe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                mealList.Add(savedMeal);

                // Serialize the list back to JSON and write it to the file.
                string updatedJson = JsonSerializer.Serialize(mealList, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, updatedJson);

                MessageBox.Show("Recipe saved successfully.", "Recipe Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
