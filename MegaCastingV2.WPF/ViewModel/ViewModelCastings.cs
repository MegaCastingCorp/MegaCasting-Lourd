using MegaCastingV2.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace MegaCastingV2.WPF.ViewModel
{
    public class ViewModelCastings : ViewModelBase
    {
        #region Attributes

        /// <summary>
        /// Collection de castings
        /// </summary>
        private ObservableCollection<Producer> _Producer;

        /// <summary>
        /// Collection de castings
        /// </summary>
        private ObservableCollection<Offer> _Offers;

        /// <summary>
        /// Selectionne un Castings
        /// </summary>
        private Offer _SelectedOffers;

        private string _nameProducer;



        #endregion

        #region Properties

        public string nameProducer
        {
            get { return _nameProducer; }
            set { _nameProducer = value; }
        }

        /// <summary>
        /// Obtient ou défini la collection de castings
        /// </summary>
        public ObservableCollection<Producer> Producer
        {
            get { return _Producer; }
            set { _Producer = value; }
        }

        /// <summary>
        /// Obtient ou défini la collection de castings
        /// </summary>
        public ObservableCollection<Offer> Offers
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
            this.Offers = this.Entities.Offers.Local;

            this.Entities.Producers.ToList();
            this.Producer = this.Entities.Producers.Local;

        }

        #endregion

        #region Methods
        public void SetNameProducer()
        {
            foreach (Producer producers in Producer)
            {
                if (producers.Identifier == SelectedOffers.Producer.Identifier) 
                {
                    this.nameProducer = producers.Name; 
                }
            }
        }

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
        public void AddCastings(string text)
        {
            if (text.Any())
            {
                if (!this.Entities.Offers.Any(type => !(type.Name != text )))
                {
                    MessageBoxResult result = MessageBox.Show("Souhaitez-vous confirmer l'ajout", "Ajout d'un casting", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.Yes)
                    {
                        Offer offer = new Offer();
                        offer.Name = text;
                        this.Offers.Add(offer);

                        this.Entities.SaveChanges();
                        this.SelectedOffers = offer;
                    }
                }
                else
                {
                    MessageBox.Show("Le casting existe déjà");
                }
            }
            else
            {
                MessageBox.Show("Veuillez saisir un nom et une durée");
            }
        }

        /// <summary>
        /// Supprime le castings sélectionné
        /// </summary>
        public void DeleteCastings()
        {
            //Vérification si on a le droit de supprimer

            if (SelectedOffers == null)
            {
                MessageBox.Show("Vous devez selectionner un casting pour le supprimer");
            }
            else if (!SelectedOffers.Producer.Offers.Any())
            {
                MessageBoxResult result = MessageBox.Show("Souhaitez-vous confimer la suppression", "Suppresion d'un Type de Contrat", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {

                    // Suppression de l'élément
                    this.Entities.Offers.Remove(SelectedOffers);
                    this.Entities.SaveChanges();
                    this.Offers.Remove(SelectedOffers);
                }
            }
            else
            {
                MessageBox.Show("Vous ne pouvez pas supprimer car il existe encore au moins une offre lier à un producteur");
            }
        }
        #endregion

    }
}
