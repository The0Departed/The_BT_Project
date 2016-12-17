using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_BT_Project
{
    class Role
    {
        #region Properties
        public int ID { get; set; }
        public string Name { get; set; }
        #endregion
        #region Relations
        public virtual ICollection<User> Users { get; set; }

        #endregion
    }
}
