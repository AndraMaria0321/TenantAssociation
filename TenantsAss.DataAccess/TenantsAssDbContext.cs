using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TenantsAss.DataModel;

namespace TenantsAss.DataAccess
{
    public class TenantsAssDbContext: IdentityDbContext<IdentityUser>
    {
        public TenantsAssDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Apartment> Apartment { get; set; }

        public DbSet<Building> Building { get; set; }

        public DbSet<Invoice> Invoice { get; set; }

    }
}
