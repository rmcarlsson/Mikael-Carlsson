﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DataModel;
using System.Data.Entity;

namespace BeerControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
            
        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            var cxt = new RecipeContext();


        }

        private void mnuIngredientsMalts_Click(object sender, RoutedEventArgs e)
        {
            MaltWindow win = new MaltWindow();
            win.Show();
        }

        private void mnuIngredientsMalts_Click_1(object sender, RoutedEventArgs e)
        {
            MaltWindow mw = new MaltWindow();
            mw.Show();
        }

        private void addMaltbutton_Click(object sender, RoutedEventArgs e)
        {
            MaltWindow mw = new MaltWindow();
            mw.Show();

        }
    }
}
