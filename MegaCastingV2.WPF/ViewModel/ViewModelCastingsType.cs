using MegaCastingV2.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MegaCastingV2.WPF.ViewModel
{
    public class ViewModelCastingsType : ViewModelBase
    {
        #region Attributes

        /// <summary>
        /// Collection de castings
        /// </summary>
        private ObservableCollection<CASTING> _CastingsType;

        /// <summary>
        /// Selectionne un Castings
        /// </summary>
        private CASTING _SelectedCastingsType;

        #endregion

        #region Properties

        /// <summary>
        /// Obtient ou défini la collection de castings
        /// </summary>
        public ObservableCollection<CASTING> CastingsType
        {
            get { return _CastingsType; }
            set { _CastingsType = value; }
        }

        /// <summary>
        /// Ontient ou defeni le type de castings selectionne
        /// </summary>
        public CASTING SelectedCastingsType
        {
            get { return _SelectedCastingsType; }
            set { _SelectedCastingsType = value; }
        }

        #endregion


        #region Constructor
        public ViewModelCastingsType(Entities entities) : base(entities)
        {
            this.Entities.CASTINGS.ToList();
            this.CastingsType = this.Entities.CASTINGS.Local;
        }

        #endregion

    }
}
