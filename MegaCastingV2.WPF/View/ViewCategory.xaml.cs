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

        private void _ButtonResetCategorie_Click(object sender, RoutedEventArgs e)
        {
            if (_ListBoxCategory.SelectedItem != null)
            {
                _ListBoxCategory.UnselectAll();
            }
            else
            {
                MessageBox.Show("Veuillez selectionner un utilisateur à renitialiser.");
            }
        }
    }
}
