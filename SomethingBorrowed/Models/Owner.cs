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

        [Required(ErrorMessage = "First Name Required")]
        [Display(Name = "First Name")]
        public String OwnerFirstName { get; set; }

        [Required(ErrorMessage = "Last Name Required")]
        [Display(Name = "Last Name")]
        public String OwnerLastName { get; set; }

        [EmailAddress(ErrorMessage = "Please Input a Valid Email Address")]
        [Required(ErrorMessage = "Email Address Required")]
        [Display(Name = "Email Address Name")]
        public String OwnerEmail { get; set; }

        [Required(ErrorMessage = "Street Address Required")]
        [Display(Name = "Street Address")]
        public String OwnerAddress { get; set; }

        [Required(ErrorMessage = "City Required")]
        [Display(Name = "City")]
        public String OwnerCity { get; set; }

        public virtual int? StateID { get; set; }
        public virtual State state { get; set; }

        [Required(ErrorMessage = "Zipcode Required")]
        [Display(Name = "Zipcode Name")]
        [StringLength(5, ErrorMessage = "Zipcode must be 5 digits", MinimumLength = 5)]
        public String OwnerZip { get; set; }

        [Required(ErrorMessage = "Bank Account Required")]
        [Display(Name = "Bank Account Number")]
        public String OwnerBankAccount { get; set; }

        [Phone]
        [Required(ErrorMessage = "Phone Required")]
        [Display(Name = "Phone Number")]
        public String OwnerPhone { get; set; }
    }
}