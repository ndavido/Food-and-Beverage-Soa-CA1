using System.Text.Json;
using RestSharp.Serializers;
using RestSharp;

namespace Food_and_Beverage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Load_Beverages();
            Load_Food();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void Beverages_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Food_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}