using System;
using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DataSeeder
{
    public static class Seeder
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Project>().HasData(new Project
            {
                Id = 1,
                ProjectName = "Project1",
                CreatedBy = "Berkay",
                CreatedDate = DateTime.Now,
                ModifiedBy = "Berkay",
                ModifiedDate = null,

            });
            modelBuilder.Entity<WebApps>().HasData(new WebApps
            {
                Id = 1,
                CreatedDate = DateTime.Now,
                ModifiedDate = null,
                CreatedBy = "Berkay",
                ModifiedBy = null,
                WebAppType = WebAppType.WebApi,
                WebAppUrl = "www.google.com.tr/",
                ProjectId = 1,

            });

            modelBuilder.Entity<WebAppDetails>().HasData(new WebAppDetails
            {
                Id = 1,
                CreatedDate = DateTime.Now,
                ModifiedDate = null,
                WebAppAltUrl = "www.google.com.tr/altUrl1",
                CreatedBy = "Berkay",
                ModifiedBy = null,
                WebAppId = 1

            });
            modelBuilder.Entity<WebAppDetails>().HasData(new WebAppDetails
            {
                Id = 2,
                CreatedDate = DateTime.Now,
                ModifiedDate = null,
                WebAppAltUrl = "www.google.com.tr/altUrl2",
                CreatedBy = "Berkay",
                ModifiedBy = null,
                WebAppId = 1

            });
            modelBuilder.Entity<WebAppDetails>().HasData(new WebAppDetails
            {
                Id = 3,
                CreatedDate = DateTime.Now,
                ModifiedDate = null,
                WebAppAltUrl = "www.google.com.tr/altUrl3",
                CreatedBy = "Berkay",
                ModifiedBy = null,
                WebAppId = 1

            });


        }
    }
}