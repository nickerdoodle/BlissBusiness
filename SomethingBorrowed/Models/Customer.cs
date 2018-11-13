using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SomethingBorrowed.Models
{
    public class Customer
    {
        /*[Table("Customer")]*/
        [Key]
        public int customerID { get; set; }
        [Required(ErrorMessage ="Error")]
        public String customerFirstName { get; set; }
        [Required(ErrorMessage = "Error")]
        public String customerLastName { get; set; }
        [Required(ErrorMessage = "Error")]
        [DataType(DataType.PhoneNumber)]
        public String phone { get; set; }
        [Required(ErrorMessage = "Error")]
        [EmailAddress]
        public String email { get; set; }

    }
}