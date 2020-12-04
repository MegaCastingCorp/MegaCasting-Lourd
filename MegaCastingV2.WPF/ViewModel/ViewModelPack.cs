using MegaCastingV2.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void AddPack()
        {
            if (!this.Entities.Packs
                .Any(type => type.Label == "Nom du pack")
                )
            {
                Pack pack = new Pack();
                pack.Label = "Pack";
                this.Pack.Add(pack);
                this.SaveChanges();
                this.SelectedPack = pack;
            }
        }

        /// <summary>
        /// Supprime le pack selectionné
        /// </summary>
        public void RemovePack()
        {
            // Vérification si on a le droit de supprimer

            //Suppression de l'élément
            this.Pack.Remove(SelectedPack);
            this.SaveChanges();
        }


        #endregion

    }
}
