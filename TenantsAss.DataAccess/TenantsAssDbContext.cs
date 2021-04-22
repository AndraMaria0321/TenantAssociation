using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TenantsAss.DataModel;

namespace TenantsAss.DataAccess
{
    public class TenantsAssDbContext: DbContext
    {
        public TenantsAssDbContext(DbContextOptions<TenantsAssDbContext> options) : base(options)
        { }

        public DbSet<Apartment> Apartment { get; set; }

        public DbSet<Building> Building { get; set; }

        public DbSet<Invoice> Invoice { get; set; }

        public DbSet<User> User { get; set; }

        
    }
}
