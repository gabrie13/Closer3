using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Closer3.Models
{
    public class EmployeeViewModel
    {
        [Key]
        public int EmployeeId { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Name
        {
            get
            {
                return String.Format ( "{0} {1}", this.FirstName, this.LastName);
            }
        }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Hire Date")]
        [DataType(DataType.Date)]
        public DateTime DateOfHire { get; set; }

        [DataType(DataType.Currency)]
        public decimal Wage { get; set; }
    }
}