using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Models
{
    public class DatabaseContext : System.Data.Entity.DbContext
    {
        #region Cunstructors
        public DatabaseContext() : base("BT_Library")
        {

        }

        static DatabaseContext()
        {
            System.Data.Entity.Database.SetInitializer
                (new DropCreateDatabaseIfModelChanges<DatabaseContext>());
        }
        #endregion
    }
}
