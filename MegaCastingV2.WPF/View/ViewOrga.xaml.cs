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
    /// Logique d'interaction pour ViewOrganisation.xaml
    /// </summary>
    public partial class ViewOrganisation : UserControl
    {
        public ViewOrganisation()
        {
            InitializeComponent();
        }

        private void _ButtonSearchOrga_Click(object sender, RoutedEventArgs e)
        {

        }

        private void _ButtonAddOrga_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelOrga)this.DataContext).AddOrga(this._SelectOrgName.Text);
        }

        private void _ButtonRemoveOrga_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelOrga)this.DataContext).RemoveOrga();
        }

        private void _ButtonSaveOrg_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelOrga)this.DataContext).SaveChanges();
        }

        private void _ButtonResetOrga_Click(object sender, RoutedEventArgs e)
        {
            if (_ListBoxOrga.SelectedItem != null)
            {
                _ListBoxOrga.UnselectAll();
            }
            else
            {
                MessageBox.Show("Veuillez selectionner un utilisateur à renitialiser.");
            }

        }
    }
}
