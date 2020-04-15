using Microsoft.EntityFrameworkCore;
using SE.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SE.DAL
{
    public class SEContext : DbContext
    {
        public SEContext(DbContextOptions<SEContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Downloading> Downloadings { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(a => a.Comments)
                .WithOne(f => f.User)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                .HasMany(a => a.Downloadings)
                .WithOne(f => f.User)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                .HasMany(a => a.Ratings)
                .WithOne(f => f.User)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                .HasMany(a => a.Materials)
                .WithOne(f => f.User)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
