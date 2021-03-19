using System;
using System.Linq;

namespace IS413_GroupProject.Models
{
    // Connecting the repository to the context file which is pulling from the database

    public class EFTourRepository : iTourRepository
    {

        private TourDbContext _context;

        public EFTourRepository (TourDbContext context)
        {
            _context = context;
        }

        public IQueryable<Tour> Tours => _context.Tours;

        public IQueryable<Group> Groups => _context.Groups;
    }
}
