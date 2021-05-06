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
    /// Logique d'interaction pour ViewContractType.xaml
    /// </summary>
    public partial class ViewContractType : UserControl
    {
        public ViewContractType()
        {
            InitializeComponent();
        }

        private void _ButtonAddContractType_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelContractType)this.DataContext).AddContractType(this._SelectNameContractType.Text);
        }

        private void _ButtonRemoveContractType_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelContractType)this.DataContext).DeleteContractType();
        }

        private void _ButtonSaveContractType_Click(object sender, RoutedEventArgs e)
        {
            ((ViewModelContractType)this.DataContext).SaveChanges();
        }

    }
}
