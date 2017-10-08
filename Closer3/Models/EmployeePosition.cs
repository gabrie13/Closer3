using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Closer3.Models
{
    public class EmployeePosition
    {
        [Key]
        public int EmployeePositionId { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        [ForeignKey("Position")]
        public int Positionid { get; set; }

        // LAZY LOADING TO POPULATE THE DROP DOWN LIST ASSOCIATING THE EMPLOYEE AND POSITION
        public virtual Employee Employee { get; set; }
        public virtual Position Position { get; set; }
    }
}