using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace salonkrasotbl.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Services> Servicess { get; set; }
        public DbSet<Orders> Orderss { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Customer> Customers { get; set; }

    }
}