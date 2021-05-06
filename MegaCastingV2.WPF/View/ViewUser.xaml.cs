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
    /// Logique d'interaction pour ViewUser.xaml
    /// </summary>
    public partial class ViewUser : UserControl
    {
        public ViewUser()
        {
            InitializeComponent();
        }

        private void _ButtonAddUser_Click(object sender, RoutedEventArgs e)
        {
        }

        private void _ButtonRemoveUser_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelUser)this.DataContext).DeleteUser();

        }

        private void _ListBoxUserTypes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void _ButtonSaveUser_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelUser)this.DataContext).SaveChanges();
        }

    }
}
