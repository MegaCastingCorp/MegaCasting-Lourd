using MegaCastingV2.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingV2.WPF.ViewModel
{
    public class ViewModelUserType : ViewModelBase 
    {
        #region Atributes

        /// <summary>
        /// Collection de users
        /// </summary>
        private ObservableCollection<USER> _UserType;

        /// <summary>
        /// Selectionne le user
        /// </summary>
        private USER _SelectedUserType;

        #endregion

        #region Properties

        /// <summary>
        /// Obtient ou défini la collection
        /// </summary>
        public ObservableCollection<USER> UserType
        {
            get { return _UserType; }
            set { _UserType = value; }
        }

        /// <summary>
        /// Obtient ou défini le type de contrat sélectionner
        /// </summary>
        public USER SelectedUserType
        {
            get { return _SelectedUserType; }
            set { _SelectedUserType = value; }
        }
        #endregion

        #region Constructors
        public ViewModelUserType(Entities entities) : base(entities)
        {
            this.Entities.USERS.ToList();
            this.UserType = this.Entities.USERS.Local;
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
        /// Ajoute un nouveau utilisateur
        /// </summary>
        public void AddUserType()
        {
            if (!this.Entities.USERS
                .Any(type => type.USERNAME == "Nouvel utilisateur")
                )
            {
                USER userType = new USER();
                userType.USERNAME = "Nouvel utilisateur";
                this.UserType.Add(userType);
                this.SaveChanges();
                this.SelectedUserType = userType;
            }
        }

        /// <summary>
        /// Supprime le contrat sélectionné
        /// </summary>
        public void DeleteUserType()
        {
            // Vérification si on a le droit de supprimer

            //Suppression de l'élément
            this.UserType.Remove(SelectedUserType);
            this.SaveChanges();
        }
        #endregion
    }
}
