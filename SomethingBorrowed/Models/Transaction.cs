using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SomethingBorrowed.Models
{
    public class Transaction
    {
        /*[Table("Transaction")]*/
        [Key]
        [Required(ErrorMessage = "Error")]
        public int transactionID { get; set; }
        /* [ForeignKey]*/
        [Required(ErrorMessage = "Error")]
        public int dressID { get; set; }
        [Required(ErrorMessage = "Error")]
        public string transactionDate { get; set; }
        [Required(ErrorMessage = "Error")]
        public int price { get; set; }
        [Required(ErrorMessage = "Error")]
        public string startRentalDate { get; set; }
        [Required(ErrorMessage = "Error")]
        public string endRentalDate { get; set; }
    }
}