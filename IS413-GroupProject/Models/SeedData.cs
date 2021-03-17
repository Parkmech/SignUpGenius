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
                       AppointmentDate = new DateTime(2021, 4, 5, 8, 0, 0),
                       TourType = "Full Tour",
                       GroupSize = 30,
                       Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                       Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 5, 9, 0, 0),
                        TourType = "Half Tour",
                        GroupSize = 30,
                        Description = "Go over to Morgan Farm, good for small children or groups before 5pm.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 5, 10, 0, 0),
                        TourType = "Half Tour",
                        GroupSize = 30,
                        Description = "Go over to Morgan Farm, good for small children or groups before 5pm.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 5, 11, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 5, 12, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 5, 13, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 5, 14, 0, 0),
                        TourType = "Trailer Tour",
                        GroupSize = 8,
                        Description = "Learn about the site and the temple from inside the trailer.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 5, 15, 0, 0),
                        TourType = "Trailer Tour",
                        GroupSize = 30,
                        Description = "Learn about the site and the temple from inside the trailer.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 5, 16, 0, 0),
                        TourType = "Half Tour",
                        GroupSize = 30,
                        Description = "Go over to Morgan Farm, good for small children or groups before 5pm.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 5, 17, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 5, 18, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 5, 19, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 5, 20, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 6, 8, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 6, 9, 0, 0),
                        TourType = "Half Tour",
                        GroupSize = 30,
                        Description = "Go over to Morgan Farm, good for small children or groups before 5pm.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 6, 10, 0, 0),
                        TourType = "Half Tour",
                        GroupSize = 30,
                        Description = "Go over to Morgan Farm, good for small children or groups before 5pm.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 6, 11, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 6, 12, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 6, 13, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 6, 14, 0, 0),
                        TourType = "Trailer Tour",
                        GroupSize = 8,
                        Description = "Learn about the site and the temple from inside the trailer.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 6, 15, 0, 0),
                        TourType = "Trailer Tour",
                        GroupSize = 30,
                        Description = "Learn about the site and the temple from inside the trailer.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 6, 16, 0, 0),
                        TourType = "Half Tour",
                        GroupSize = 30,
                        Description = "Go over to Morgan Farm, good for small children or groups before 5pm.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 6, 17, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 6, 18, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 6, 19, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 6, 20, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 7, 8, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 7, 9, 0, 0),
                        TourType = "Half Tour",
                        GroupSize = 30,
                        Description = "Go over to Morgan Farm, good for small children or groups before 5pm.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 7, 10, 0, 0),
                        TourType = "Half Tour",
                        GroupSize = 30,
                        Description = "Go over to Morgan Farm, good for small children or groups before 5pm.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 7, 11, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 7, 12, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 7, 13, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 7, 14, 0, 0),
                        TourType = "Trailer Tour",
                        GroupSize = 8,
                        Description = "Learn about the site and the temple from inside the trailer.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 7, 15, 0, 0),
                        TourType = "Trailer Tour",
                        GroupSize = 30,
                        Description = "Learn about the site and the temple from inside the trailer.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 7, 16, 0, 0),
                        TourType = "Half Tour",
                        GroupSize = 30,
                        Description = "Go over to Morgan Farm, good for small children or groups before 5pm.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 7, 17, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 7, 18, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 7, 19, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 7, 20, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 8, 8, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 8, 9, 0, 0),
                        TourType = "Half Tour",
                        GroupSize = 30,
                        Description = "Go over to Morgan Farm, good for small children or groups before 5pm.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 8, 10, 0, 0),
                        TourType = "Half Tour",
                        GroupSize = 30,
                        Description = "Go over to Morgan Farm, good for small children or groups before 5pm.",
                        Language = "Spanish"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 8, 11, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 8, 12, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "Spanish"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 8, 13, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 8, 14, 0, 0),
                        TourType = "Trailer Tour",
                        GroupSize = 8,
                        Description = "Learn about the site and the temple from inside the trailer.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 8, 15, 0, 0),
                        TourType = "Trailer Tour",
                        GroupSize = 30,
                        Description = "Learn about the site and the temple from inside the trailer.",
                        Language = "Spanish"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 8, 16, 0, 0),
                        TourType = "Half Tour",
                        GroupSize = 30,
                        Description = "Go over to Morgan Farm, good for small children or groups before 5pm.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 8, 17, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 8, 18, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "Spanish"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 8, 19, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 8, 20, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 9, 8, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 9, 9, 0, 0),
                        TourType = "Half Tour",
                        GroupSize = 30,
                        Description = "Go over to Morgan Farm, good for small children or groups before 5pm.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 9, 10, 0, 0),
                        TourType = "Half Tour",
                        GroupSize = 30,
                        Description = "Go over to Morgan Farm, good for small children or groups before 5pm.",
                        Language = "Spanish"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 9, 11, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 9, 12, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "Spanish"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 9, 13, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 9, 14, 0, 0),
                        TourType = "Trailer Tour",
                        GroupSize = 8,
                        Description = "Learn about the site and the temple from inside the trailer.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 9, 15, 0, 0),
                        TourType = "Trailer Tour",
                        GroupSize = 30,
                        Description = "Learn about the site and the temple from inside the trailer.",
                        Language = "Spanish"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 9, 16, 0, 0),
                        TourType = "Half Tour",
                        GroupSize = 30,
                        Description = "Go over to Morgan Farm, good for small children or groups before 5pm.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 9, 17, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 9, 18, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "Spanish"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 9, 19, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 9, 20, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 10, 8, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 10, 9, 0, 0),
                        TourType = "Half Tour",
                        GroupSize = 30,
                        Description = "Go over to Morgan Farm, good for small children or groups before 5pm.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 10, 10, 0, 0),
                        TourType = "Half Tour",
                        GroupSize = 30,
                        Description = "Go over to Morgan Farm, good for small children or groups before 5pm.",
                        Language = "Spanish"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 10, 11, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 10, 12, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "Spanish"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 10, 13, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 10, 14, 0, 0),
                        TourType = "Trailer Tour",
                        GroupSize = 8,
                        Description = "Learn about the site and the temple from inside the trailer.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 10, 15, 0, 0),
                        TourType = "Trailer Tour",
                        GroupSize = 30,
                        Description = "Learn about the site and the temple from inside the trailer.",
                        Language = "Spanish"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 10, 16, 0, 0),
                        TourType = "Half Tour",
                        GroupSize = 30,
                        Description = "Go over to Morgan Farm, good for small children or groups before 5pm.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 10, 17, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 10, 18, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "Spanish"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 10, 19, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 10, 20, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 11, 8, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 11, 9, 0, 0),
                        TourType = "Half Tour",
                        GroupSize = 30,
                        Description = "Go over to Morgan Farm, good for small children or groups before 5pm.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 11, 10, 0, 0),
                        TourType = "Half Tour",
                        GroupSize = 30,
                        Description = "Go over to Morgan Farm, good for small children or groups before 5pm.",
                        Language = "Spanish"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 11, 11, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 11, 12, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "Spanish"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 11, 13, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 11, 14, 0, 0),
                        TourType = "Trailer Tour",
                        GroupSize = 8,
                        Description = "Learn about the site and the temple from inside the trailer.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 11, 15, 0, 0),
                        TourType = "Trailer Tour",
                        GroupSize = 30,
                        Description = "Learn about the site and the temple from inside the trailer.",
                        Language = "Spanish"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 11, 16, 0, 0),
                        TourType = "Half Tour",
                        GroupSize = 30,
                        Description = "Go over to Morgan Farm, good for small children or groups before 5pm.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 11, 17, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 11, 18, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "Spanish"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 11, 19, 0, 0),
                        TourType = "Full Tour",
                        GroupSize = 30,
                        Description = "Walk the perimeter of the site, sturdy shoes recommended.",
                        Language = "English"
                    },

                    new Tour
                    {
                        AppointmentDate = new DateTime(2021, 4, 11, 20, 0, 0),
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
