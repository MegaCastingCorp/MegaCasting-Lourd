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
        private ObservableCollection<PACK> _Pack;

        /// <summary>
        /// Selectionne un pack
        /// </summary>
        private PACK _SelectedPack;

        #endregion

        #region Properties
        /// <summary>
        /// Obtient ou defini la collection de pack
        /// </summary>
        public ObservableCollection<PACK> Pack
        {
            get { return _Pack; }
            set { _Pack = value; }
        }

        /// <summary>
        /// Obtient ou defini la selection de pack
        /// </summary>
        public PACK SelectedPack
        {
            get { return _SelectedPack; }
            set { _SelectedPack = value; }
        }

        #endregion

        #region Constructor

        public ViewModelPack(Entities entities) : base(entities)
        {
            this.Entities.PACKs.ToList();
            this.Pack = this.Entities.PACKs.Local;
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
            if (!this.Entities.PACKs
                .Any(type => type.NAME_PACK == "Nom du pack")
                )
            {
                PACK pack = new PACK();
                pack.NAME_PACK = "Pack";
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
