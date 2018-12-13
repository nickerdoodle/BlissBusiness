﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SomethingBorrowed.Models
{
    public class Dress
    {
       /* [Table("Dress")]*/
        [Key]
        public int dressID { get; set; }
        /* [ForeignKey]*/
        public virtual Owner Owner { get; set; }
        public virtual int ownerID { get; set; }
        
        public String designer { get; set; }
        public String year { get; set; }
        public String color { get; set; }
        public Double pricePaid { get; set; }
        public String size { get; set; }


    }
}