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

namespace KiemtraKethucMon
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Meo meo = new Meo();
            meo.tiengkeu = "Meo meo";
            meo.maulong = "nâu";
            meo.Keu();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Cho cho = new Cho();
            cho.tiengkeu = "Gâu gâu";
            cho.maulong = "trắng";
            cho.Keu();
        }
    }
}
