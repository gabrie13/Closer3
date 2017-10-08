using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Closer3.Models
{
    public class Closer3DB : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Closer3DB() : base("name=Closer3DB")
        {
        }

        public System.Data.Entity.DbSet<Closer3.Models.Position> Positions { get; set; }

        public System.Data.Entity.DbSet<Closer3.Models.Location> Locations { get; set; }

        public System.Data.Entity.DbSet<Closer3.Models.Employee> Employees { get; set; }

        //public System.Data.Entity.DbSet<Closer3.Models.CashRegister> CashRegisters { get; set; }
    
    }
}
