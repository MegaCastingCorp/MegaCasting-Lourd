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


        /// <summary>
        /// Ajoute une nouvelle Organisation
        /// </summary>
        public void AddOrganisation()
        {
            if (!this.Entities.Producers
                .Any(type => type.Name == "Nom orga")
                )
            {
                Producer orga = new Producer();
                orga.Name = "Organisation";
                this.Producer.Add(orga);
                this.SaveChanges();
                this.SelectedProducer = orga;
            }
        }

        /// <summary>
        /// Supprime l'Organisation selectionnée
        /// </summary>
        public void RemoveOrga()
        {
            // Vérification si on a le droit de supprimer

            //Suppression de l'élément
            this.Producer.Remove(SelectedProducer);
            this.SaveChanges();
        }


        #endregion

    }
}
