using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SomethingBorrowed.Models
{
    [Table("State")]
    public class State
    {
        [Key]
        public int StateID { get; set; }
        public String StateDesc { get; set; }
    }
}