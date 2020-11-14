using MegaCastingV2.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MegaCastingV2.WPF.ViewModel
{
    public class ViewModelCastings : ViewModelBase
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
        public ViewModelCastings(Entities entities) : base(entities)
        {
            this.Entities.CASTINGS.ToList();
            this.CastingsType = this.Entities.CASTINGS.Local;
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


        /// <summary>
        /// Ajoute un nouveau castings
        /// </summary>
        public void AddCastings()
        {
            if (!this.Entities.CASTINGS
                .Any(type => type.LABEL == "Nouveau casting")
                )
            {
                CASTING castings = new CASTING();
                castings.LABEL = "Casting";
                this.CastingsType.Add(castings);
                this.SaveChanges();
                this.SelectedCastingsType = castings;
            }
        }

        /// <summary>
        /// Supprime le castings sélectionné
        /// </summary>
        public void DeleteCastings()
        {
            // Vérification si on a le droit de supprimer

            //Suppression de l'élément
            this.CastingsType.Remove(SelectedCastingsType);
            this.SaveChanges();
        }
        #endregion

    }
}
