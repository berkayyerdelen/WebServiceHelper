using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServiceHelper.Entities.Domains;

namespace WebServiceHelper.Entities.DataSeeder
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
                WebServices = new List<WebApps>() {
                    new WebApps()
                    {
                        Id = 1,
                        CreatedDate = DateTime.Now,
                        ModifiedDate = null,
                        CreatedBy = "Berkay",
                        ProjectId = 1,
                        ModifiedBy = null,
                        WebAppType =WebAppType.WebApi,
                        WebAppUrl = "www.google.com.tr/",
                        WebAppDetails = new List<WebAppDetails>()
                        {
                            new WebAppDetails()
                            {
                               Id =1,
                               CreatedDate =DateTime.Now,
                               ModifiedDate= null,
                               WebAppAltUrl ="www.google.com.tr/altUrl1",
                               CreatedBy ="Berkay",
                               ModifiedBy =null,
                               WebAppId =1
                              
                            },
                             new WebAppDetails()
                            {
                               Id =2,
                               CreatedDate =DateTime.Now,
                               ModifiedDate= null,
                               WebAppAltUrl ="www.google.com.tr/altUrl2",
                               CreatedBy ="Berkay",
                               ModifiedBy =null,
                               WebAppId =1

                            },
                              new WebAppDetails()
                            {
                               Id =3,
                               CreatedDate =DateTime.Now,
                               ModifiedDate= null,
                               WebAppAltUrl ="www.google.com.tr/altUrl3",
                               CreatedBy ="Berkay",
                               ModifiedBy =null,
                               WebAppId =1

                            },
                                  new WebAppDetails()
                            {
                               Id =4,
                               CreatedDate =DateTime.Now,
                               ModifiedDate= null,
                               WebAppAltUrl ="www.google.com.tr/altUrl4",
                               CreatedBy ="Berkay",
                               ModifiedBy =null,
                               WebAppId =1

                            },
                                      new WebAppDetails()
                            {
                               Id =5,
                               CreatedDate =DateTime.Now,
                               ModifiedDate= null,
                               WebAppAltUrl ="www.google.com.tr/altUrl5",
                               CreatedBy ="Berkay",
                               ModifiedBy =null,
                               WebAppId =1

                            }
                        }

                    }}


            });
        }
    }
}
