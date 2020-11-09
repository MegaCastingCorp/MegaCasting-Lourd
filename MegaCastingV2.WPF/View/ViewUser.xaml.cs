using MegaCastingV2.WPF.ViewModel;
using MegaCastingV2.WPF.View.Popup;
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
    /// Logique d'interaction pour ViewUserType.xaml
    /// </summary>
    public partial class ViewUser : UserControl
    {
        public ViewUser()
        {
            InitializeComponent();
        }


        private void _ButtonAddUserType_Click(object sender, RoutedEventArgs e)
        {
            PopupAddUser popupAddUser = new PopupAddUser();
            popupAddUser.DataContext = this.DataContext;
            popupAddUser.ShowDialog();
        }

        private void _ButtonRemoveUserType_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelUserType)this.DataContext).DeleteUserType();
        }

        private void _ButtonSaveUser_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelUserType)this.DataContext).SaveChanges();
        }

        private void _ButtonSearchUser_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RemoveTextBar(object sender, RoutedEventArgs e)
        {
            if (BoxSearchUser.Text == "Rechercher un utilisateur...")
            {
                BoxSearchUser.Text = "";
            }
        }

        private void AddTextBar(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BoxSearchUser.Text))
                BoxSearchUser.Text = "Recherche un utilisateur...";

        }

    }
}
