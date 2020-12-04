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
        private ObservableCollection<Offer> _Offers;

        /// <summary>
        /// Selectionne un Castings
        /// </summary>
        private Offer _SelectedOffers;

        #endregion

        #region Properties

        /// <summary>
        /// Obtient ou défini la collection de castings
        /// </summary>
        public ObservableCollection<Offer> Offer
        {
            get { return _Offers; }
            set { _Offers = value; }
        }

        /// <summary>
        /// Ontient ou defeni le type de castings selectionne
        /// </summary>
        public Offer SelectedOffers
        {
            get { return _SelectedOffers; }
            set { _SelectedOffers = value; }
        }

        #endregion


        #region Constructor
        public ViewModelCastings(Entities entities) : base(entities)
        {
            this.Entities.Offers.ToList();
            this.Offer = this.Entities.Offers.Local;
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
            if (!this.Entities.Offers
                .Any(type => type.Name == "Nouveau casting")
                )
            {
                Offer castings = new Offer();
                castings.Name = "Casting";
                this.Offer.Add(castings);
                this.SaveChanges();
                this.SelectedOffers = castings;
            }
        }

        /// <summary>
        /// Supprime le castings sélectionné
        /// </summary>
        public void DeleteCastings()
        {
            // Vérification si on a le droit de supprimer

            //Suppression de l'élément
            this.Offer.Remove(SelectedOffers);
            this.SaveChanges();
        }
        #endregion

    }
}
