using System;
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
        private List<Meal> _mealList; // Assuming Meal is the correct class for the food items

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
            if (FoodListBox.SelectedIndex != -1)
            {
                var selectedMeal = _mealList[FoodListBox.SelectedIndex];

                // Assuming you have a PictureBox named 'mealPictureBox'
                // and a Label or TextBox named 'ingredientsTextBox' for displaying the ingredients.
                mealPictureBox.Load(selectedMeal.strMealThumb); // Load image from URL.

                // Concatenate ingredients into a single string.
                var ingredients = new StringBuilder();
                for (int i = 1; i <= 20; i++) // Adjust the number as per the meal ingredients available.
                {
                    var ingredientProp = selectedMeal.GetType().GetProperty($"strIngredient{i}");
                    var ingredient = (string)ingredientProp?.GetValue(selectedMeal);
                    if (!string.IsNullOrWhiteSpace(ingredient))
                    {
                        ingredients.AppendLine(ingredient);
                    }
                }

                // Assuming you have a control to display ingredients.
                ingredientsTextBox.Text = ingredients.ToString();
            }
        }
    }
}
