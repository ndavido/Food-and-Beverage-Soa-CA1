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
        public MealControl()
        {
            InitializeComponent();
            Load_Food();
        }

        private void Load_Food()
        {
            var client = new RestClient("https://www.themealdb.com/api/json/v1/1/search.php?s");
            var request = new RestRequest();

            var response = client.Execute(request);

            Rootobject_Food foodRootObject = JsonSerializer.Deserialize<Rootobject_Food>(response.Content);

            foreach (var food in foodRootObject.meals)
            {
                FoodListBox.Items.Add(food.strMeal);
            }
        }
    }
}
