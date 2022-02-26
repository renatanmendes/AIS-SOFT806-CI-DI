using Microsoft.EntityFrameworkCore;
using SOFT806_ClassActivity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SOFT806_ClassActivity.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Admin>().HasData(new Admin
            {
                AdminID = 1,
                FirstName = "Admin",
                LastName = "AIS",
                Email = "example@ais.co.nz",
                Password = "123456",
                ConfirmPassword = "123456",

            });

        }



        public DbSet<Admin> Admins { get; set; }
        public DbSet<Users> Users { get; set; }


            }
}
