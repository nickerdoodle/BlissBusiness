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
    }
}