using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MegaCastingV2.DBLib;


namespace MegaCastingV2.WPF.ViewModel
{
    public class ViewModelContractType : ViewModelBase
    {
        #region Atributes

        /// <summary>
        /// Collection de contrat
        /// </summary>
        private ObservableCollection<ContractType> _ContractType;

        /// <summary>
        /// Selectionne une contrat
        /// </summary>
        private ContractType _SelectedContractType;


        /// <summary>
        /// Nom du producteur associé à l'offre
        /// </summary>
        private Producer _nameProducer;

        #endregion

        #region Properties

        /// <summary>
        /// Obtient ou défini le nom du producteur associé à l'offre
        /// </summary>
        public Producer nameProducer
        {
            get { return _nameProducer; }
            set { _nameProducer = value; }
        }

        /// <summary>
        /// Obtient ou defini la contrat selectionné
        /// </summary>
        public ContractType SelectedContractType
        {
            get { return _SelectedContractType; }
            set { _SelectedContractType = value; }
        }

        /// <summary>
        /// Obtient ou defini la collection de contrat
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

            this.Entities.Producers.ToList();
        }

        #endregion

        #region Methods

        //public void setNameProducer()
        //{
        //    foreach (Producer producer in nameProducer)
        //    {
        //        if (producer.Identifier == ContractType.)
        //        {
        //            this.nameProducer = SelectedContractType.
        //        }
        //    }
        //}

        /// <summary>
        /// Sauvegarde les modifications
        /// </summary>
        public void SaveChanges()
        {
            this.Entities.SaveChanges();
        }

        ///<summary>
        /// Ajout d'un contrat
        /// </summary>
        public void AddContractType(string text)
        {
            if (text.Any())
            {
                if (!this.Entities.ContractTypes.Any(type => type.Name == text))
                {
                    MessageBoxResult result = MessageBox.Show("Souhaitez-vous confirmer l'ajout", "Ajout d'un type de job", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.Yes)
                    {
                        ContractType contract = new ContractType();
                        contract.Name = text;
                        this.ContractType.Add(contract);

                        this.Entities.SaveChanges();
                        this.SelectedContractType = contract;
                    }
                }
                else
                {
                    MessageBox.Show("Le contrat existe déjà");
                }
            }
            else
            {
                MessageBox.Show("Veuillez saisir un Nom");
            }
        }


        ///<summary>
        /// Suppression d'un contrat
        /// </summary>
        public void DeleteContractType()
        {
            //Vérification si on a le droit de supprimer

            if (SelectedContractType == null)
            {
                MessageBox.Show("Vous devez selectionner un type de Contrat pour le supprimer");
            }
            else if (!SelectedContractType.Offers.Any())
            {
                MessageBoxResult result = MessageBox.Show("Souhaitez-vous confirmer la suppression", "Suppresion d'un Type de Contrat", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {

                    // Suppression de l'élément
                    this.Entities.ContractTypes.Remove(SelectedContractType);
                    this.Entities.SaveChanges();
                    this.ContractType.Remove(SelectedContractType);
                }
            }
            else
            {
                MessageBox.Show("Vous ne pouvez pas supprimer car il existe encore au moins une offre lier à un type de contrat");
            }


            #endregion

        }
    }
}
