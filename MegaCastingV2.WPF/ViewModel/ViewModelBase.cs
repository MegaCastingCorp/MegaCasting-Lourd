using MegaCastingV2.DBLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingV2.WPF.ViewModel
{
    /// <summary>
    /// Base des modèles-vues. Contient tous les élements que l'on retrouve systématiquement
    /// </summary>
    public abstract class ViewModelBase
    {
        #region Attributes

        /// <summary>
        /// Contexte de l'application
        /// </summary>
        private Entities _Entities;

        #endregion

        #region Properties

        /// <summary>
        /// Obtient ou défini le contexte de l'application
        /// </summary>
        public Entities Entities
        {
            
            get { return _Entities; }
            set { _Entities = value; }
        }

        #endregion

        /// <summary>
        /// Constructeur du modèle-vue de la fenêtre principale
        /// </summary>
        /// <param name="entities">Contexte de l'application</param>
        public ViewModelBase(Entities entities)
        {
            this.Entities = entities;
        }

    }
}
