using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BulkBook.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BulkBook.DataAccess
{
    public class ApplicationDbContext:IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<CoverType> CoverTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }


    public DbSet<AdCategories> AdCategories { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Ads> Ads { get; set; }
    public DbSet<Categories> Category { get; set; }
    public DbSet<Cities> Cities { get; set; }
    public DbSet<Deadline> Deadlines { get; set; }
    public DbSet<District> Districts { get; set; }
    public DbSet<User> Users { get; set; }
  


  }



}
