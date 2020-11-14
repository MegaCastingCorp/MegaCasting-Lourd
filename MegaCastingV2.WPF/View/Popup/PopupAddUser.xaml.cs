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
using System.Windows.Shapes;

namespace MegaCastingV2.WPF.View.Popup
{
    /// <summary>
    /// Logique d'interaction pour PopupAddUser.xaml
    /// </summary>
    public partial class PopupAddUser : Window
    {
        public PopupAddUser()
        {
            InitializeComponent();
        }

        private void _ButtonAddUser_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelUser)this.DataContext).AddUserType();
        }


        private void RemoveText(object sender, RoutedEventArgs e)
        {
            if (PopBoxLastname.Text == "Nom"
                || PopBoxFirstName.Text == "Prénom" 
                || PopBoxUsername.Text == "Nom d'utilisateur" 
                || PopBoxPassword.Text == "Mot de passe" 
                || PopBoxEmail.Text == "Email")
            {
                PopBoxLastname.Text = "";
                PopBoxFirstName.Text = "";
                PopBoxUsername.Text = "";
                PopBoxPassword.Text = "";
                PopBoxEmail.Text = "";
            }
        }

        private void AddText(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PopBoxLastname.Text))
                PopBoxLastname.Text = "Nom";
            else if (string.IsNullOrWhiteSpace(PopBoxFirstName.Text))
                PopBoxFirstName.Text = "Prénom";
            else if (string.IsNullOrWhiteSpace(PopBoxUsername.Text))
                PopBoxUsername.Text = "Nom d'utilisateur";
            else if (string.IsNullOrWhiteSpace(PopBoxPassword.Text))
                PopBoxPassword.Text = "Mot de passe";
            else if (string.IsNullOrWhiteSpace(PopBoxEmail.Text))
                PopBoxEmail.Text = "Email";

        }
    }
}
