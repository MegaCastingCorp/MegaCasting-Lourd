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
        /// Supprime le contrat sélectionné
        /// </summary>
        public void DeleteUser()
        {
            //Vérification si on a le droit de supprimer

            if (SelectedUser == null)
            {
                MessageBox.Show("Vous devez selectionner un utilisateur pour le supprimer");
            }
            else if (!SelectedUser.Username.Any())
            {
                MessageBoxResult result = MessageBox.Show("Souhaitez-vous confimer la suppression", "Suppresion d'un Type de Contrat", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {

                    // Suppression de l'élément
                    this.Entities.Users.Remove(SelectedUser);
                    this.Entities.SaveChanges();
                    this.User.Remove(SelectedUser);
                }
            }
            else
            {
                MessageBox.Show("Vous ne pouvez pas supprimer car il existe encore au moins une offre lié a l'utilisateur");
            }
        }
        #endregion
    }
}
