using Microsoft.EntityFrameworkCore;
using SE.Common;
using SE.DAL.Entities;
using System;
using System.Collections.Generic;

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
            var guid1 = Guid.NewGuid();
            var guid2 = Guid.NewGuid();

            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = guid1,
                    Name = "admin",
                    Surname = "admin",
                    Email = "admin@admin.com",
                    Password = Crypto.Sha256("admin" + "admin@admin.com"),
                    Role = Enums.Role.Admin,
                    IsConfirmed = true
                },
                new User
                {
                    Id = guid2,
                    Name = "Max",
                    Surname = "Grechuha",
                    Email = "max.grechuha@mail.ru",
                    Password = Crypto.Sha256("123123" + "max.grechuha@mail.ru"),
                    Role = Enums.Role.User,
                    IsConfirmed = true
                }
            );
            var r = new Random();
            var materials = new List<Material>();

            for(int i = 1; i <= 100; i++)
            {
                materials.Add(new Material
                {
                    Id = Guid.NewGuid(),
                    Name = "NameNameName" + i,
                    UserId = i % 2 == 1 ? guid1 : guid2,
                    Description = "DescriptionDescriptionDescriptionDescription" + i,
                    Status = i % 2 == 1 ? Enums.MaterialStatus.Published : Enums.MaterialStatus.OnModeration,
                    PublishingDate = DateTime.Now,
                    Auditory = Enums.Auditory.Teachers,
                    Theme = (Enums.Theme)r.Next(1, 6),
                    Type = (Enums.Type)r.Next(1, 5),
                    DownloadingLink = i % 2 == 1 ? "https://www.freepng.ru/png-miditu/download.html" : "https://ru.wikipedia.org/wiki/Международная_организация_гражданской_авиации",
                    Picture = new byte[] {1,2,3},
                    SourceOfInformation = "SourceOfInformationSourceOfInformation"+i,
                    Rating = r.Next(1, 5),
                    DownloadsCount = r.Next(1, 100)
                });
            }

            modelBuilder.Entity<Material>().HasData(materials);

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
