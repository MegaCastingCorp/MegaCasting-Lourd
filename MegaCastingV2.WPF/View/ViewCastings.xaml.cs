﻿using MegaCastingV2.WPF.ViewModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MegaCastingV2.WPF.View
{
    /// <summary>
    /// Logique d'interaction pour ViewCastingsType.xaml
    /// </summary>
    public partial class ViewCastings : UserControl
    {
        public ViewCastings()
        {
            InitializeComponent();
        }

        private void _ButtonSaveCastings_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelCastings)this.DataContext).SaveChanges();
        }

        private void _ButtonAddCastings_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _ButtonSearchCastings_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _ButtonRemoveCastings_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelCategory)this.DataContext).RemoveCategory();
        }

        private void RemoveTextBar(object sender, RoutedEventArgs e)
        {
            if (BoxSearchCastings.Text == "Rechercher un casting...")
            {
                BoxSearchCastings.Text = "";
            }
        }

        private void AddTextBar(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BoxSearchCastings.Text))
                BoxSearchCastings.Text = "Recherche un casting...";

        }
    }
}
