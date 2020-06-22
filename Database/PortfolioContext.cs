using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Portfolio.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Database
{
    public class PortfolioContext : IdentityDbContext
    {
        public PortfolioContext(DbContextOptions<PortfolioContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProjectTag>().HasKey(pt => new { pt.ProjectId, pt.TagId });

            modelBuilder.Entity<Status>().HasData(new Status { Id = 1, Title = "Toekomstig project" });
            modelBuilder.Entity<Status>().HasData(new Status { Id = 2, Title = "Huidig project" });
            modelBuilder.Entity<Status>().HasData(new Status { Id = 3, Title = "Afgewerkt project" });


            modelBuilder.Entity<Tag>().HasData(new Tag { Id = 1, Title = "C#" });
            modelBuilder.Entity<Tag>().HasData(new Tag { Id = 2, Title = "ASP.NET" });
            modelBuilder.Entity<Tag>().HasData(new Tag { Id = 3, Title = "HTML" });
            modelBuilder.Entity<Tag>().HasData(new Tag { Id = 4, Title = "CSS" });
            modelBuilder.Entity<Tag>().HasData(new Tag { Id = 5, Title = "WinForms" });
            modelBuilder.Entity<Tag>().HasData(new Tag { Id = 6, Title = "Classes" });
            modelBuilder.Entity<Tag>().HasData(new Tag { Id = 7, Title = "Javascript" });

        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectTag> ProjectTags { get; set; }
        public DbSet<Status> statuses { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
