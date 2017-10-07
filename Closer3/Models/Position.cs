using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Closer3.Models
{
    public class Position
    {
        [Key]
        public int PositionId { get; set; }

        public string PositionTitle { get; set; }
    }
}