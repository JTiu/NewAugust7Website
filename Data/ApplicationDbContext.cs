using August7thWebsite.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace August7thWebsite.Data
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
       
        public DbSet<Participant> Participants { get; set; }
        public DbSet<LineUp> LineUps { get; set; }
        public DbSet<TicketBuyer> TicketBuyers { get; set; }
    }
}
