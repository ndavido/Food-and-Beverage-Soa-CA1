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

    }
}
