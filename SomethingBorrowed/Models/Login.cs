using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SomethingBorrowed.Models
{
    [Table("Login")]
    public class Login
    {
        [Key]
        public int LoginID { get; set; }
        [EmailAddress]
        public String Email { get; set; }
        [DataType(DataType.Password)]
        public String Password { get; set; }
    }
}