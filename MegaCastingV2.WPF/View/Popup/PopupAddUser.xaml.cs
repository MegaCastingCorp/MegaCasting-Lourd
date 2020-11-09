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
            ((ViewModelUserType)this.DataContext).AddUserType();
        }
    }
}
