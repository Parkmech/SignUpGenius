using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace IS413_GroupProject.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            TourDbContext context = application.ApplicationServices.
                CreateScope().ServiceProvider.GetRequiredService<TourDbContext>();

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if(!context.Tours.Any())
            {
                context.Tours.AddRange(

                    new Tour
                    {
                       AppointmentDate = new DateTime(2021, 4, 1, 8, 0, 0),
                       TourType = "Full Tour",
                       GroupSize = 30,
                       Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                       Language = "English"


                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 1, 9, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 1, 10, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 1, 11, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 1, 12, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    }

                    );

                context.SaveChanges();
            }
        }
    }
}
