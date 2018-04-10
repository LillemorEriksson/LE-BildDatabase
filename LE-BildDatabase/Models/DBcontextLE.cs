using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LE_BildDatabase.Models
{
    public class DBContextLE : DbContext
    {
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Prices> Prices { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
    }
}