using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SomethingBorrowed.Models
{
    [Table("Dress")]
    public class Dress
    {
       
        [Key]
        [Display(Name = "Dress ID")]
        public int dressID { get; set; }
        /* [ForeignKey]*/
        public virtual Owner Owner { get; set; }
        public virtual int? OwnerID { get; set; }

        [Display(Name = "Designer")]
        public String DressDesigner { get; set; }
        [Display(Name = "Year Purchased ")]
        [DataType(DataType.Date)]
        public DateTime DressYear { get; set; }
        [Display(Name = "Color")]
        public String DressColor { get; set; }
        [Display(Name = "Price Paid")]
        public Decimal DressPricePaid { get; set; }
        public virtual DressSize DressSize { get; set; }
        public virtual int DressSizeID { get; set; }


    }
}