using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DataModel;
using System.Data.Entity;

namespace BeerControl
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MaltWindow : Window
    {
        public MaltWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var cxt = new RecipeContext();
            System.Windows.Data.CollectionViewSource maltViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("maltViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // maltViewSource.Source = [generic data source]

            // Load is an extension method on IQueryable,  
            // defined in the System.Data.Entity namespace. 
            // This method enumerates the results of the query,  
            // similar to ToList but without creating a list. 
            // When used with Linq to Entities this method  
            // creates entity objects and adds them to the context. 
            cxt.Malts.Load();

            // After the data is loaded call the DbSet<T>.Local property  
            // to use the DbSet<T> as a binding source. 
            maltViewSource.Source = cxt.Malts.Local;
        }
    }
}
