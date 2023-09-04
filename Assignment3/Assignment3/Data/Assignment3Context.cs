using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Assignment3.Data
{
    public class Assignment3Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Assignment3Context() : base("name=Assignment3Context")
        {
        }

        public System.Data.Entity.DbSet<Assignment3.Models.Class> Classes { get; set; }

        public System.Data.Entity.DbSet<Assignment3.Models.Member> Members { get; set; }

        public System.Data.Entity.DbSet<Assignment3.Models.Membership> Memberships { get; set; }

        public System.Data.Entity.DbSet<Assignment3.Models.Registration> Registrations { get; set; }

        public System.Data.Entity.DbSet<Assignment3.Models.Session> Sessions { get; set; }
    }
}
