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
            modelBuilder.Entity<Material>().HasData(
                 new Material
                 {
                     Id = Guid.NewGuid(),
                     Name = "NameNameNameNameName1",
                     UserId = guid1,
                     Description = "DescriptionDescriptionDescriptionDescription",
                     Status = Enums.MaterialStatus.Published,
                     PublishingDate = DateTime.Now,
                     Auditory = Enums.Auditory.Teachers,
                     Theme = Enums.Theme.ChildAndSociety,
                     Type = Enums.Type.Articles,
                     DownloadingLink = "DownloadingLinkDownloadingLinkDownloadingLinkDownloadingLink",
                     Picture = new byte[] { 1, 2 },
                     SourceOfInformation = "SourceOfInformationSourceOfInformationSourceOfInformationSourceOfInformation",
                     Rating = 0,
                     DownloadsCount = 0
                 },
                 new Material
                 {
                     Id = Guid.NewGuid(),
                     Name = "Name2Name2Name2Name2Name2",
                     UserId = guid1,
                     Description = "DescriptionDescriptionDescriptionDescription",
                     Status = Enums.MaterialStatus.Published,
                     PublishingDate = DateTime.Now,
                     Auditory = Enums.Auditory.Teachers,
                     Theme = Enums.Theme.FireSafety,
                     Type = Enums.Type.Illustrations,
                     DownloadingLink = "DownloadingLinkDownloadingLinkDownloadingLinkDownloadingLink",
                     Picture = new byte[] { 1, 2 },
                     SourceOfInformation = "SourceOfInformationSourceOfInformationSourceOfInformationSourceOfInformation",
                     Rating = 0,
                     DownloadsCount = 0
                 },
                 new Material
                 {
                     Id = Guid.NewGuid(),
                     Name = "Name3Name3Name3Name3Name3",
                     UserId = guid1,
                     Description = "DescriptionDescriptionDescriptionDescription",
                     Status = Enums.MaterialStatus.Published,
                     PublishingDate = DateTime.Now,
                     Auditory = Enums.Auditory.Teachers,
                     Theme = Enums.Theme.HumanAndNature,
                     Type = Enums.Type.Presentation,
                     DownloadingLink = "DownloadingLinkDownloadingLinkDownloadingLinkDownloadingLink",
                     Picture = new byte[] { 1, 2 },
                     SourceOfInformation = "SourceOfInformationSourceOfInformationSourceOfInformationSourceOfInformation",
                     Rating = 0,
                     DownloadsCount = 0
                 },
                 new Material
                 {
                     Id = Guid.NewGuid(),
                     Name = "Name4Name4Name4Name4Name4",
                     UserId = guid1,
                     Description = "DescriptionDescriptionDescriptionDescription",
                     Status = Enums.MaterialStatus.Published,
                     PublishingDate = DateTime.Now,
                     Auditory = Enums.Auditory.Teachers,
                     Theme = Enums.Theme.SafetyAtHome,
                     Type = Enums.Type.Video,
                     DownloadingLink = "DownloadingLinkDownloadingLinkDownloadingLinkDownloadingLink",
                     Picture = new byte[] { 1, 2 },
                     SourceOfInformation = "SourceOfInformationSourceOfInformationSourceOfInformationSourceOfInformation",
                     Rating = 0,
                     DownloadsCount = 0
                 },
                 new Material
                 {
                     Id = Guid.NewGuid(),
                     Name = "Name5Name5Name5Name5Name5Name5",
                     UserId = guid1,
                     Description = "DescriptionDescriptionDescriptionDescription",
                     Status = Enums.MaterialStatus.Published,
                     PublishingDate = DateTime.Now,
                     Auditory = Enums.Auditory.Teachers,
                     Theme = Enums.Theme.TrafficRules,
                     Type = Enums.Type.Summaries,
                     DownloadingLink = "DownloadingLinkDownloadingLinkDownloadingLinkDownloadingLink",
                     Picture = new byte[] { 1, 2 },
                     SourceOfInformation = "SourceOfInformationSourceOfInformationSourceOfInformationSourceOfInformation",
                     Rating = 0,
                     DownloadsCount = 0
                 },
                 new Material
                 {
                     Id = Guid.NewGuid(),
                     Name = "Name6Name6Name6Name6Name6Name6",
                     UserId = guid1,
                     Description = "DescriptionDescriptionDescriptionDescription",
                     Status = Enums.MaterialStatus.Published,
                     PublishingDate = DateTime.Now,
                     Auditory = Enums.Auditory.Teachers,
                     Theme = Enums.Theme.Common,
                     Type = Enums.Type.Articles,
                     DownloadingLink = "DownloadingLinkDownloadingLinkDownloadingLinkDownloadingLink",
                     Picture = new byte[] { 1, 2 },
                     SourceOfInformation = "SourceOfInformationSourceOfInformationSourceOfInformationSourceOfInformation",
                     Rating = 0,
                     DownloadsCount = 0
                 },
                 new Material
                 {
                     Id = Guid.NewGuid(),
                     Name = "Name7Name7Name7Name7Name7",
                     UserId = guid1,
                     Description = "DescriptionDescriptionDescriptionDescription",
                     Status = Enums.MaterialStatus.Published,
                     PublishingDate = DateTime.Now,
                     Auditory = Enums.Auditory.Teachers,
                     Theme = Enums.Theme.ChildAndSociety,
                     Type = Enums.Type.Presentation,
                     DownloadingLink = "DownloadingLinkDownloadingLinkDownloadingLinkDownloadingLink",
                     Picture = new byte[] { 1, 2 },
                     SourceOfInformation = "SourceOfInformationSourceOfInformationSourceOfInformationSourceOfInformation",
                     Rating = 0,
                     DownloadsCount = 0
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
