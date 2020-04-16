using Microsoft.EntityFrameworkCore;
using SE.Common;
using SE.DAL.Entities;
using System;

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
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = Guid.NewGuid(),
                    Name = "admin",
                    Surname = "admin",
                    Email = "admin@admin.com",
                    Password = Crypto.Sha256("admin" + "admin@admin.com"),
                    Role = Enums.Role.Admin,
                    IsConfirmed = true
                },
                new User
                {
                    Id = Guid.NewGuid(),
                    Name = "Max",
                    Surname = "Grechuha",
                    Email = "max.grechuha@mail.ru",
                    Password = Crypto.Sha256("123123" + "max.grechuha@mail.ru"),
                    Role = Enums.Role.User,
                    IsConfirmed = true
                }
            );

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
