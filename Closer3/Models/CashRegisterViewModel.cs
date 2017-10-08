using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Closer3.Models
{
    public class CashRegisterViewModel
    {
        [Key]
        public int RegisterId { get; set; }

        [DisplayFormat(DataFormatString = "{0:C0}") ]
        [DataType(DataType.Currency)]
        public decimal Cash { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        [DataType(DataType.Currency)]
        public decimal Check { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        [DataType(DataType.Currency)]
        public decimal Visa { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        [DataType(DataType.Currency)]
        public decimal MasterCard { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        [DataType(DataType.Currency)]
        public decimal Discover { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        [DataType(DataType.Currency)]
        public decimal Amex { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        [DataType(DataType.Currency)]
        [Display(Name = "Gift Card")]
        public decimal GiftCard { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        [DataType(DataType.Currency)]
        public decimal Tax { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        [DataType(DataType.Currency)]
        [Display(Name = "Credit Total")]
        public decimal CcTotal { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        [DataType(DataType.Currency)]
        public decimal Total { get; set; }
    }
}