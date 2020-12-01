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
        private ObservableCollection<CASTING> _Castings;

        public ObservableCollection<CASTING> Castings
        {
            get { return _Castings; }
            set { _Castings = value; }
        }

        #region Constructor
        public ViewModelStat(Entities entities)
            : base(entities)
        {
            this.Entities.CASTINGS.ToList();
            this.Castings = this.Entities.CASTINGS.Local;
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
                previousyear.Add((from o in this.Entities.CASTINGS
                                  where o.DATE_DEB_CONTRACT.Month == i
                                  select o).Where(o => (o.DATE_DEB_CONTRACT.Year == previousYearFromDatetime)).Count());
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
                currentyear.Add((from o in this.Entities.CASTINGS
                                 where o.DATE_DEB_CONTRACT.Month == j
                                 select o).Where(o => (o.DATE_DEB_CONTRACT.Year == today.Year)).Count());
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
