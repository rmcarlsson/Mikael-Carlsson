using DataModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BeerControl
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Database.SetInitializer(new RecipeContextInitializer());
            var cxt = new RecipeContext();
            cxt.Database.Initialize(true);
        }
    }
}
