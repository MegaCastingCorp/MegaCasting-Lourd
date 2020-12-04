using MegaCastingV2.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingV2.WPF.ViewModel
{
    public class ViewModelStat : ViewModelBase
    {
        private ObservableCollection<Offer> _Offers;

        public ObservableCollection<Offer> Offers
        {
            get { return _Offers; }
            set { _Offers = value; }
        }

        #region Constructor
        public ViewModelStat(Entities entities)
            : base(entities)
        {
            this.Entities.Offers.ToList();
            this.Offers = this.Entities.Offers.Local;
        }

        #endregion

        /// <summary>
        /// Gets all offers from the previous year and count how much there are for each month
        /// </summary>
        /// <returns> List of this count for all month y-1</returns>
        public List<int> PreviousYear()
        {
            List<int> previousyear = new List<int>();
            DateTime today = DateTime.Now;
            int previousYearFromDatetime = today.AddYears(-1).Year;
            for (int i = 1; i <= 12; i++)
            {
                previousyear.Add((from o in this.Entities.Offers
                                  where o.PublishDateTime.Month == i
                                  select o).Where(o => (o.PublishDateTime.Year == previousYearFromDatetime)).Count());
            }
            return previousyear;
        }
        /// <summary>
        /// Gets all offers from the current year and count how much there are for each month
        /// </summary>
        /// <returns> List of this count for all month y</returns>
        public List<int> CurrentYear()
        {
            DateTime today = DateTime.Now;
            List<int> currentyear = new List<int>();
            for (int j = 1; j <= 12; j++)
            {
                currentyear.Add((from o in this.Entities.Offers
                                 where o.PublishDateTime.Month == j
                                 select o).Where(o => (o.PublishDateTime.Year == today.Year)).Count());
            }
            return currentyear;

        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
