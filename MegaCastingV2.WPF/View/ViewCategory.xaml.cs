using MegaCastingV2.WPF.ViewModel;
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
    /// Logique d'interaction pour ViewCategory.xaml
    /// </summary>
    public partial class ViewCategory : UserControl
    {
        public ViewCategory()
        {
            InitializeComponent();
        }

        private void _ButtonSearchCategory_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _ButtonSaveCategory_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelCategory)this.DataContext).SaveChanges();
        }

        private void _ButtonAddCategorie_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelCategory)this.DataContext).AddCategory(this._SelectCategorieLabel.Text);
        }

        private void _ButtonRemoveCategorie_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelCategory)this.DataContext).RemoveCategory();
        }

        private void RemoveTextBar(object sender, RoutedEventArgs e)
        {
            if (BoxSearchCategory.Text == "Rechercher une categorie...")
            {
                BoxSearchCategory.Text = "";
            }
        }

        private void AddTextBar(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BoxSearchCategory.Text))
                BoxSearchCategory.Text = "Recherche une categorie...";

        }

    }
}
