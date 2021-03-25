using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCastingV2.DBLib;


namespace MegaCastingV2.WPF.ViewModel
{
    public class ViewModelContractType : ViewModelBase
    {
        #region Atributes

        /// <summary>
        /// Collection de Category
        /// </summary>
        private ObservableCollection<ContractType> _ContractType;

        /// <summary>
        /// Selectionne une cateogrie
        /// </summary>
        private ContractType _SelectedContractType;

        #endregion

        #region Properties

        /// <summary>
        /// Obtient ou defini la category selectionné
        /// </summary>
        public ContractType SelectedContractType
        {
            get { return _SelectedContractType; }
            set { _SelectedContractType = value; }
        }

        /// <summary>
        /// Obtient ou defini la collection de category
        /// </summary>
        public ObservableCollection<ContractType> ContractType
        {
            get { return _ContractType; }
            set { _ContractType = value; }
        }

        #endregion


        #region Constructor

        public ViewModelContractType(Entities entities) : base(entities)
        {
            this.Entities.ContractTypes.ToList();
            this.ContractType = this.Entities.ContractTypes.Local;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Sauvegarde les modifications
        /// </summary>
        public void SaveChanges()
        {
            this.Entities.SaveChanges();
        }

        #endregion

    }
}
