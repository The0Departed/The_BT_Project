using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class DatabaseContextInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        public DatabaseContextInitializer()
        {

        }

        //این تابع فقط زمانی اجرا می شود که بانک اطلاعاتی می خواهد ایجاد شود اگر وجود داشته باشد صدا زده نمیشود
        protected override void Seed(DatabaseContext databaseContext)
        {

        }
    }
}
