using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_and_Beverage
{
    internal class SaveRecipe
    {
    }
}

public class SavedRecipe
{
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public List<string> Ingredients { get; set; } = new List<string>();
    public string Instructions { get; set; }
}