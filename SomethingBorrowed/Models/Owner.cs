using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SomethingBorrowed.Models
{
    [Table("Owner")]
    public class Owner
    {
        [Key]
        public int OwnerID { get; set; }

        public String OwnerFirstName { get; set; }

        public String OwnerLastName { get; set; }

        [EmailAddress]
        public String OwnerEmail { get; set; }

        public String OwnerAddress { get; set; }

        public String OwnerCity { get; set; }

        public String OwnerState { get; set; }

        public String OwnerZip { get; set; }

        public String OwnerBankAccount { get; set; }

        [Phone]
        public String OwnerPhone { get; set; }
    }
}