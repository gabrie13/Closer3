using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Closer3.Models
{
    public class Closer3DbSetInitializer : DropCreateDatabaseAlways<Closer3DB>
    {
        protected override void Seed(Closer3DB context)
        {
            base.Seed(context);
        }
    }
}