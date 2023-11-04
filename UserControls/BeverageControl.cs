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
        public BeverageControl()
        {
            InitializeComponent();
            Load_Beverages();
        }

        private void Load_Beverages()
        {
            var client = new RestClient("https://www.thecocktaildb.com/api/json/v1/1/search.php?s");
            var request = new RestRequest();

            var response = client.Execute(request);

            Rootobject_Beverage beverageRootObject = JsonSerializer.Deserialize<Rootobject_Beverage>(response.Content);

            foreach (var beverage in beverageRootObject.drinks)
            {
                BeveragesListBox.Items.Add(beverage.strDrink);
            }
        }
    }
}
