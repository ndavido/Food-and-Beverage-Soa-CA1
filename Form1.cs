using System.Text.Json;
using RestSharp.Serializers;
using RestSharp;
using Food_and_Beverage.UserControls;

namespace Food_and_Beverage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HomeControl uc = new();
            addUserControl(uc);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            HomeControl uc = new();
            addUserControl(uc);
        }

        private void BeveregeBtn_Click(object sender, EventArgs e)
        {
            BeverageControl uc = new();
            addUserControl(uc);
        }

        private void MealBtn_Click(object sender, EventArgs e)
        {
            MealControl uc = new();
            addUserControl(uc);
        }

        private void savedBtn_Click(object sender, EventArgs e)
        {
            SavedRecipesControl uc = new SavedRecipesControl();
            addUserControl(uc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void Beverages_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Food_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}