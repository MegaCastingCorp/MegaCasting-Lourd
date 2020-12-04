using MegaCastingV2.DBLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingV2.WPF.ViewModel
{
    public class ViewModelMain : ViewModelBase
    {
        /// <summary>
        /// Nombre d'utilisateur
        /// </summary>
        private int _NbUsers;

        /// <summary>
        /// Otient ou défini le nombre d'utilisateur
        /// </summary>
        public int NbUsers
        {
            get { return _NbUsers; }
            set { _NbUsers = value; }
        }

        /// <summary>
        /// Compte les utilisateurs
        /// </summary>
        /// <returns></returns>
        private int CountUser()
        {
            return this.Entities.Users.Count();

        }

        /// <summary>
        /// Assocation de la variable pour compter à la fonction
        /// </summary>
        /// <param name="entities"></param>
        public ViewModelMain(Entities entities) : base(entities)
        {
            this.NbUsers = CountUser();
        }

    }
}
