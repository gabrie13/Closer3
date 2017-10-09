using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Closer3.Models
{
    public class CashReg
    {
        [Key]
        public int CashRegisterId { get; set; }

        public decimal Cash { get; set; }

        public decimal Check { get; set; }

        public decimal Visa { get; set; }

        public decimal MasterCard { get; set; }

        public decimal Discover { get; set; }

        public decimal Amex { get; set; }

        public decimal GiftCard { get; set; }

        public decimal Tax { get; set; }
    }
}