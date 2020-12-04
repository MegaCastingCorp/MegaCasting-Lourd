using MegaCastingV2.DBLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingV2.WPF.ViewModel
{
    public class ViewModelUser : ViewModelBase 
    {
        #region Atributes

        /// <summary>
        /// Collection de users
        /// </summary>
        private ObservableCollection<User> _User;

        /// <summary>
        /// Selectionne le user
        /// </summary>
        private User _SelectedUser;

        #endregion

        #region Properties

        /// <summary>
        /// Obtient ou défini la collection
        /// </summary>
        public ObservableCollection<User> User
        {
            get { return _User; }
            set { _User = value; }
        }

        /// <summary>
        /// Obtient ou défini le type de contrat sélectionner
        /// </summary>
        public User SelectedUser
        {
            get { return _SelectedUser; }
            set { _SelectedUser = value; }
        }
        #endregion

        #region Constructors
        public ViewModelUser(Entities entities) : base(entities)
        {
            this.Entities.Users.ToList();
            this.User = this.Entities.Users.Local;
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
            if (!this.Entities.Users
                .Any(type => type.Username == "Nouvel utilisateur")
                )
            {
                User user = new User();
                user.Username = "Username";
                this.User.Add(user);
                this.SaveChanges();
                this.SelectedUser = user;
            }
        }

        /// <summary>
        /// Supprime le contrat sélectionné
        /// </summary>
        public void DeleteUserType()
        {
            // Vérification si on a le droit de supprimer

            //Suppression de l'élément
            this.User.Remove(SelectedUser);
            this.SaveChanges();
        }
        #endregion
    }
}
