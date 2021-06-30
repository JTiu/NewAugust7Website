using Box_Themis_Capstone.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Box_Themis_Capstone.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>()
            .HasData(
            new IdentityRole
            //{
            //    Name = "Admin",
            //    NormalizedName = "ADMIN"

            //},

            {
                Name = "Judge",
                NormalizedName = "JUDGE"
            }
            );

        }
       
        public DbSet<Judge> Judges { get; set; }//#ask is this in the right place?
        public DbSet<ScoreCard> ScoreCards { get; set; }//changed to private?
    }
}
