using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Closer3.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        public int PositionId { get; set; }

        public int LocationId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public DateTime DateOfHire { get; set; }

        public decimal Wage { get; set; }

        // LAZY LOADING DROP DOWN LIST : POSITION, LOCATION
        public virtual Position Position { get; set; }
        public virtual Location Location { get; set; }
    }
}