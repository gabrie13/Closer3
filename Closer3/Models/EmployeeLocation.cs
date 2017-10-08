using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Closer3.Models
{
    public class EmployeeLocation
    {
        [Key]
        public int EmployeeLocationId { get; set; }
        
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        [ForeignKey("Location")]
        public int LocationId { get; set; }

        // LAZY LOADING TO POPULATE THE DROP DOWN LIST TO ASSOCIATE THE EMPLOYEE WITH THEIR LOCATION
        public virtual Employee Employee { get; set; }
        public virtual Location Location { get; set; }
    }
}