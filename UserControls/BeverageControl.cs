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
    public partial class BeverageControl : UserControl
    {
        private List<Drink> _beverageList;

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
            if (BeveragesListBox.SelectedIndex != -1)
            {
                var selectedBeverage = _beverageList[BeveragesListBox.SelectedIndex];

                // Assuming you have a PictureBox named 'beveragePictureBox'
                // and a Label or TextBox named 'ingredientsTextBox' for displaying the ingredients.
                beveragePictureBox.Load(selectedBeverage.strDrinkThumb); // Load image from URL.

                // Concatenate ingredients into a single string.
                var ingredients = new StringBuilder();
                for (int i = 1; i <= 15; i++) // Assuming you have up to 15 ingredients.
                {
                    var ingredientProp = selectedBeverage.GetType().GetProperty($"strIngredient{i}");
                    var ingredient = (string)ingredientProp?.GetValue(selectedBeverage);
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
