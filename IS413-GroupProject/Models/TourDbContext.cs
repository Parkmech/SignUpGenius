using System;
using Microsoft.EntityFrameworkCore;

namespace IS413_GroupProject.Models
{
    public class TourDbContext : DbContext
    {
        public TourDbContext (DbContextOptions<TourDbContext> options) : base (options)
        {

        }

        public DbSet<Tour> Tours { get; set; }

        public DbSet<Group> Groups { get; set; }
    }
}
