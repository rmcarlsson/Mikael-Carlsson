using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class Recipe
    {
        public int RecipeId { set; get;  }
        public string Name { set; get;  }
        public string Description { set; get; }
        public Mash Mash { set; get; }
        public ICollection<HopsStep> HopSteps { set; get; }
        public ICollection<BoilIngredient> BoilIngredients { set; get; }

    }
}
