using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class RecipeContextInitializer : DropCreateDatabaseAlways<RecipeContext>
    {
        protected override void Seed(RecipeContext context)
        {

            //
            // Seed hops and hopssteps
            //
            var hopsList = new List<Hops>
                {
                    new Hops { Name = "Saaz", AlphaAcid = 4  },
                    new Hops { Name = "Magnus", AlphaAcid = 6  },
                    new Hops { Name = "Surte", AlphaAcid = 61  },
                    new Hops { Name = "Tranettel", AlphaAcid = 1  }
                };
            hopsList.ForEach(s => context.Hopses.Add(s));
            context.SaveChanges();

            var pilsnerHopsSteps = new List<HopsStep>
            {
                new HopsStep { aHops = hopsList[1], Amount = 42, Minutes = 0},
                new HopsStep { aHops = hopsList[1], Amount = 12, Minutes = 20},
                new HopsStep { aHops = hopsList[1], Amount = 22, Minutes = 0}
            };

            var paleAleHopsSteps = new List<HopsStep>
            {
                new HopsStep { aHops = hopsList[2], Amount = 22, Minutes = 0},
                new HopsStep { aHops = hopsList[3], Amount = 12, Minutes = 20},
                new HopsStep { aHops = hopsList[1], Amount = 62, Minutes = 0}
            };
            

            //
            // Seed Malts and mash
            //
            var maltsList = new List<Malt>
                {
                    new Malt { Name = "Pilsner", Description = "Plain Plisner malt", LDK = 300, EBC = 4 },
                    new Malt { Name = "Caramel malt", Description = "Dark malt for color", LDK = 290, EBC = 130 },
                    new Malt { Name = "Pale ale malt", Description = "Malt for pale ale beer", LDK = 310, EBC = 2  },
                };
            maltsList.ForEach(m => context.Malts.Add(m));
            context.SaveChanges();

            var mashPaleAle = new Mash {
                Malts = new List<Malt> { maltsList[1], maltsList[2] },
                TempSteps = new List<TempStep> {
                    new TempStep { Temperature = 62, Minutes = 43 },
                    new TempStep { Temperature = 67, Minutes = 12 },
                    new TempStep { Temperature = 73, Minutes = 20 }
                }
            };

            var mashPilsner = new Mash
            {
                Malts = new List<Malt> { maltsList[0] },
                TempSteps = new List<TempStep> {
                    new TempStep { Temperature = 62, Minutes = 60 }
                }
            };


            //
            // Seed recipes
            //
            var rec = new List<Recipe>
                {
                    new Recipe { Name = "Pilsner", Mash = mashPilsner, Description = "Cechz pilsner", HopSteps = pilsnerHopsSteps  },
                    new Recipe { Name = "IPA", Mash = mashPaleAle, Description = "Indian pale ale" },
                };
            rec.ForEach(h => context.Recipes.Add(h));
            context.SaveChanges();
        }
    }
}
