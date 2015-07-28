using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataModel
{
    public class RecipeContext : DbContext
    {

        public DbSet<Recipe> Recipes { set; get; }
        public DbSet<Hops> Hopses { set; get; }
        public DbSet<Malt> Malts { set; get; }

    }
   
}

