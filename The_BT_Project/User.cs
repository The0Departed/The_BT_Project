using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_BT_Project
{
    class User
    {
        #region constructors
        public User() { }
        #endregion

        #region Properties

        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        #endregion

    }
}
