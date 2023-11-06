using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Food_and_Beverage.UserControls
{
    public partial class SavedRecipesControl : UserControl
    {
        private List<SavedRecipe> _savedBeverages;
        private List<SavedRecipe> _savedMeals;

        public SavedRecipesControl()
        {
            InitializeComponent();
            LoadSavedMeals();
            LoadSavedBeverages();
        }

        private void LoadSavedMeals()
        {
            string filePath = "C:\\Y4\\Soa\\CA1\\Food and Beverage\\savedMeals.json"; // Use the correct file path for meals
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                _savedMeals = JsonConvert.DeserializeObject<List<SavedRecipe>>(json) ?? new List<SavedRecipe>();

                SavedMealBox.Items.Clear(); // Correct list box for displaying saved meals.
                foreach (var meal in _savedMeals)
                {
                    SavedMealBox.Items.Add(meal.Name); // Add meal names to the list box
                }
            }
        }

        private void LoadSavedBeverages()
        {
            string filePath = "C:\\Y4\\Soa\\CA1\\Food and Beverage\\savedBeverages.json";
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                _savedBeverages = JsonConvert.DeserializeObject<List<SavedRecipe>>(json) ?? new List<SavedRecipe>();

                SavedBeverageBox.Items.Clear(); // Assuming this is your list box for displaying saved beverages.
                foreach (var beverage in _savedBeverages)
                {
                    SavedBeverageBox.Items.Add(beverage.Name);
                }
            }
        }

        private void SavedBeverageBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ingredientsListBox.Items.Clear();
            //instructionTextBox.Clear();

            //int index = SavedBeverageBox.SelectedIndex;
            //if (index != -1)
            //{
            //    var selectedBeverage = _savedBeverages[index];

            //    beveragePictureBox.Load(selectedBeverage.ImageUrl);
            //    instructionTextBox.Text = selectedBeverage.Instructions;

            //    foreach (var ingredient in selectedBeverage.Ingredients)
            //    {
            //        ingredientsListBox.Items.Add(ingredient);
            //    }
            //}
        }
    }
}
