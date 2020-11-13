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

        private int _NbUsers;

        public int NbUsers
        {
            get { return _NbUsers; }
            set { _NbUsers = value; }
        }


        private int CountUser()
        {
            return this.Entities.USERS.Count();

        }

        public ViewModelMain(Entities entities) : base(entities)
        {
            this.NbUsers = CountUser();
        }

    }
}
