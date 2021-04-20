using MegaCastingV2.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MegaCastingV2.WPF.ViewModel
{
    public class ViewModelOrga : ViewModelBase
    {
        #region Atributes
        /// <summary>
        /// Collection des organisations
        /// </summary>
        private ObservableCollection<Producer> _Producer;

        /// <summary>
        /// Selectionne l'organisation
        /// </summary>
        private Producer _SelectedProducer;

        #endregion

        #region Properties

        /// <summary>
        /// Obtient ou defini la collection de l'organisation
        /// </summary>
        public ObservableCollection<Producer> Producer
        {
            get { return _Producer; }
            set { _Producer = value; }
        }

        /// <summary>
        /// Obtient ou defini la selection de l'organisation
        /// </summary>
        public Producer SelectedProducer
        {
            get { return _SelectedProducer; }
            set { _SelectedProducer = value; }
        }

        #endregion

        #region Constructor
        public ViewModelOrga(Entities entities) : base(entities)
        {
            this.Entities.Producers.ToList();
            this.Producer = this.Entities.Producers.Local;
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

        ///<summary>
        /// Ajout de producteur
        /// </summary>
        public void AddOrga(string text)
        {
            if (text.Any())
            {
                if (!this.Entities.Producers.Any(type => type.Name == text))
                {
                    MessageBoxResult result = MessageBox.Show("Souhaitez-vous confirmer l'ajout ?", "Ajout d'un producteur", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.Yes)
                    {
                        Producer producer = new Producer();
                        producer.Name = text;
                        this.Producer.Add(producer);

                        this.Entities.SaveChanges();
                        this.SelectedProducer = producer;
                    }
                }
                else
                {
                    MessageBox.Show("Le producteur existe déjà");
                }
            }
            else
            {
                MessageBox.Show("Veuillez saisir un nom");
            }

        }


        /// <summary>
        /// Supprime l'Organisation selectionnée
        /// </summary>
        public void RemoveOrga()
        {
          //Vérification si on a le droit de supprimer

            if (SelectedProducer == null)
            {
                MessageBox.Show("Vous devez selectionner un Type de Contrat pour le supprimer");
            }
            else if (!SelectedProducer.Offers.Any())
            {
                MessageBoxResult result = MessageBox.Show("Souhaitez-vous confimer la suppression", "Suppresion d'un Type de Contrat", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {

                    // Suppression de l'élément
                    this.Entities.Producers.Remove(SelectedProducer);
                    this.Entities.SaveChanges();
                    this.Producer.Remove(SelectedProducer);
                }
            }
            else
            {
                MessageBox.Show("Vous ne pouvez pas supprimer car il existe encore au moins une offre lié à un type de contrat");
            }
        }


        #endregion

    }
}
