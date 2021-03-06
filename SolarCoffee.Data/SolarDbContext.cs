using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SolarCoffee.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolarCoffee.Data
{
    public class SolarDbContext : IdentityDbContext
    {
        public SolarDbContext(DbContextOptions options) :base(options)  {}

        public virtual DbSet<Customer> Customers{ get; set; }
        public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }

    }
}
