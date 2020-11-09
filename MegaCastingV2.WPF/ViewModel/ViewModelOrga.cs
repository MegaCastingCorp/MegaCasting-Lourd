using MegaCastingV2.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingV2.WPF.ViewModel
{
    public class ViewModelOrga : ViewModelBase
    {
        #region Atributes
        /// <summary>
        /// Collection des organisations
        /// </summary>
        private ObservableCollection<ORGANISATION> _Organisation;

        /// <summary>
        /// Selectionne l'organisation
        /// </summary>
        private ORGANISATION _SelectedOrganisation;

        #endregion

        #region Properties

        /// <summary>
        /// Obtient ou defini la collection de l'organisation
        /// </summary>
        public ObservableCollection<ORGANISATION> Organisation
        {
            get { return _Organisation; }
            set { _Organisation = value; }
        }

        /// <summary>
        /// Obtient ou defini la selection de l'organisation
        /// </summary>
        public ORGANISATION SelectedOrganisation
        {
            get { return _SelectedOrganisation; }
            set { _SelectedOrganisation = value; }
        }

        #endregion

        #region Constructor
        public ViewModelOrga(Entities entities) : base(entities)
        {
            this.Entities.ORGANISATIONs.ToList();
            this.Organisation = this.Entities.ORGANISATIONs.Local;
        }

        #endregion

    }
}
