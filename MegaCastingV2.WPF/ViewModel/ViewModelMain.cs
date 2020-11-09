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
        public ViewModelMain(Entities entities) : base(entities)
        {
        }

        private void CountUser()
        {
            this.Entities.USERS.Count();
        }
    }
}
