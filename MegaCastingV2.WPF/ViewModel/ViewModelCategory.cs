using MegaCastingV2.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingV2.WPF.ViewModel
{
    public class ViewModelCategory : ViewModelBase
    {
        #region Atributes

        /// <summary>
        /// Collection de Category
        /// </summary>
        private ObservableCollection<CATEGORy> _Category;

        /// <summary>
        /// Selectionne une cateogrie
        /// </summary>
        private CATEGORy _SelectedCategory;

        #endregion

        #region Properties

        /// <summary>
        /// Obtient ou defini la category selectionné
        /// </summary>
        public CATEGORy SelectedCategory
        {
            get { return _SelectedCategory; }
            set { _SelectedCategory = value; }
        }

        /// <summary>
        /// Obtient ou defini la collection de category
        /// </summary>
        public ObservableCollection<CATEGORy> Category
        {
            get { return _Category; }
            set { _Category = value; }
        }

        #endregion


        #region Constructor

        public ViewModelCategory(Entities entities) : base(entities)
        {
            this.Entities.CATEGORIES.ToList();
            this.Category = this.Entities.CATEGORIES.Local;
        }

        #endregion

    }
}
