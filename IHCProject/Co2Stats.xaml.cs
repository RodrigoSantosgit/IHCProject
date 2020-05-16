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
using System.Windows.Shapes;

namespace IHCProject
{
    /// <summary>
    /// Interaction logic for Co2Stats.xaml
    /// </summary>
    public partial class Co2Stats : Window
    {
        public Co2Stats()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StatisticsWindow statistics = new StatisticsWindow();

            statistics.Show();
            this.Close();
        }
    }
}
