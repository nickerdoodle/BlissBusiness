using SomethingBorrowed.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SomethingBorrowed.DAL
{
    public class BridalContext : DbContext
    {
        public BridalContext() : base("BridalContext")
        {

        }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Dress> Dresses { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<DressSize> DressSizes { get; set; }


    }
}
