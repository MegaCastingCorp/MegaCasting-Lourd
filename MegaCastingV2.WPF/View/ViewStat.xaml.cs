using LiveCharts;
using LiveCharts.Wpf;
using MegaCastingV2.WPF.ViewModel;
using MegaCastingV2.DBLib;
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
    /// Logique d'interaction pour ViewStat.xaml
    /// </summary>
    public partial class ViewStat : UserControl
    {

        private Entities _Entities;

        public Entities Entities
        {
            get { return _Entities; }
            set { _Entities = value; }
        }

        public ViewStat()
        {
            InitializeComponent();

            this.Entities = new Entities();
            ViewModelStat viewModel = new ViewModelStat(Entities);
            this.DataContext = viewModel;

            DateTime today = DateTime.Now;
            string currentYearLabel = today.Year.ToString();
            string previousYearLabel = today.AddYears(-1).Year.ToString();
            List<int> previousYear = ((ViewModelStat)this.DataContext).PreviousYear();
            List<int> currentYear = ((ViewModelStat)this.DataContext).CurrentYear();
            var max = currentYear.Max();
            var maxN1 = previousYear.Max();
            if (max < maxN1) { MaxYValue = maxN1; }
            if (max > maxN1) { MaxYValue = max; }
            else { MaxYValue = max; }

            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = previousYearLabel,
                    Values = new ChartValues<int> { previousYear[0], previousYear[1], previousYear[2], previousYear[3], previousYear[4], previousYear[5],
                        previousYear[6], previousYear[7], previousYear[8], previousYear[9], previousYear[10], previousYear[11]}
                },
                new LineSeries
                {
                    Title = currentYearLabel,
                    Values = new ChartValues<int> { currentYear[0], currentYear[1], currentYear[2], currentYear[3], currentYear[4], currentYear[5],
                        currentYear[6], currentYear[7], currentYear[8], currentYear[9], currentYear[10], currentYear[11]}
                },
            };

            Months = new[] { "Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Decembre" };
            YFormatter = value => value.ToString("C");
            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Months { get; set; }
        public Func<int, string> YFormatter { get; set; }
        public int MaxYValue { get; set; }

    }





}
