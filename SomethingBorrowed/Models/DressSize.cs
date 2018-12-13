using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SomethingBorrowed.Models
{
    [Table("DressSize")]
    public class DressSize
    {
        [Key]
        public int DressSizeID { get; set; }
        [Display(Name = "Dress Size")]
        public Double DressSizeDesc { get; set; }
    }
}