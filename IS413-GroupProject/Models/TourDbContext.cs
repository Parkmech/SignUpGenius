using System;
using Microsoft.EntityFrameworkCore;

namespace IS413_GroupProject.Models
{
    //This model is use to pull in the tables Tour and Group from the database

    public class TourDbContext : DbContext
    {
        public TourDbContext (DbContextOptions<TourDbContext> options) : base (options)
        {

        }

        public DbSet<Tour> Tours { get; set; }

        public DbSet<Group> Groups { get; set; }
    }
}

