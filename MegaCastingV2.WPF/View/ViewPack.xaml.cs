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
    /// Logique d'interaction pour ViewPack.xaml
    /// </summary>
    public partial class ViewPack : UserControl
    {
        public ViewPack()
        {
            InitializeComponent();
        }

        private void _ButtonAddPack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _ButtonRemovePack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _ButtonSavePack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _ButtonSearchPack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveTextBar(object sender, RoutedEventArgs e)
        {
            if (BoxSearchPack.Text == "Rechercher un pack...")
            {
                BoxSearchPack.Text = "";
            }
        }

        private void AddTextBar(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BoxSearchPack.Text))
                BoxSearchPack.Text = "Recherche un pack...";

        }
    }
}
