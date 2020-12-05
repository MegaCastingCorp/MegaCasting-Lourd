using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingV2.DBLib
{
    public partial class User
    {
        public string FullName => this.Identifier.ToString() + " - " + this.Username;
        public override string ToString()
        {
            return this.Firstname.ToString();
        }
    }
}
