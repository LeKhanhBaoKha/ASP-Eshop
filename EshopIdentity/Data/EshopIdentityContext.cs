using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EshopIdentity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace EshopIdentity.Data
{
    public class EshopIdentityContext : IdentityDbContext<User>
    {
        public EshopIdentityContext (DbContextOptions<EshopIdentityContext> options)
            : base(options)
        {
        }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceDetail> InvoiceDetails { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }

        public DbSet<EshopIdentity.Models.Product> Products { get; set; } 
    }
}
