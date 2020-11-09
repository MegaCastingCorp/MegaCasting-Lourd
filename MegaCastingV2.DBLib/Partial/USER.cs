using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingV2.DBLib
{
    public partial class USER
    {
        public string FullName => this.ID_USER.ToString() + " - " + this.USER_FIRSTNAME;
        public override string ToString()
        {
            return this.USER_FIRSTNAME.ToString();
        }
    }
}
