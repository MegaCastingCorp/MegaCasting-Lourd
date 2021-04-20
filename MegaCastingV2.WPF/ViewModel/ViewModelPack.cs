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
    public class ViewModelPack : ViewModelBase
    {
        #region Atributes

        /// <summary>
        /// Collection des packs
        /// </summary>
        private ObservableCollection<Pack> _Pack;

        /// <summary>
        /// Selectionne un pack
        /// </summary>
        private Pack _SelectedPack;

        #endregion

        #region Properties
        /// <summary>
        /// Obtient ou defini la collection de pack
        /// </summary>
        public ObservableCollection<Pack> Pack
        {
            get { return _Pack; }
            set { _Pack = value; }
        }

        /// <summary>
        /// Obtient ou defini la selection de pack
        /// </summary>
        public Pack SelectedPack
        {
            get { return _SelectedPack; }
            set { _SelectedPack = value; }
        }

        #endregion

        #region Constructor

        public ViewModelPack(Entities entities) : base(entities)
        {
            this.Entities.Packs.ToList();
            this.Pack = this.Entities.Packs.Local;
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
        /// Ajoute un nouveau pack
        /// </summary>
        public void AddPack(string text)
        {
            if (text.Any())
            {
                if (!this.Entities.Producers.Any(type => type.Name == text))
                {
                    MessageBoxResult result = MessageBox.Show("Souhaitez-vous confirmer l'ajout ?", "Ajout d'un pack", MessageBoxButton.YesNo);
                    if (result == MessageBoxResult.Yes)
                    {
                        Pack pack = new Pack();
                        pack.Label = text;
                        this.Pack.Add(pack);

                        this.Entities.SaveChanges();
                        this.SelectedPack = pack;
                    }
                }
                else
                {
                    MessageBox.Show("Le pack existe déjà");
                }
            }
            else
            {
                MessageBox.Show("Veuillez saisir un nom");
            }
        }

        /// <summary>
        /// Supprime le pack selectionné
        /// </summary>
        public void RemovePack()
        {
            //Vérification si on a le droit de supprimer

            if (SelectedPack == null)
            {
                MessageBox.Show("Vous devez selectionner un pack pour le supprimer");
            }
            else if (!SelectedPack.Producers.Any())
            {
                MessageBoxResult result = MessageBox.Show("Souhaitez-vous confimer la suppression", "Suppresion d'un pack", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {

                    // Suppression de l'élément
                    this.Entities.Packs.Remove(SelectedPack);
                    this.Entities.SaveChanges();
                    this.Pack.Remove(SelectedPack);
                }
            }
            else
            {
                MessageBox.Show("Vous ne pouvez pas supprimer car il existe encore au moins un producteur lié à un pack.");
            }
        }


        #endregion

    }
}
