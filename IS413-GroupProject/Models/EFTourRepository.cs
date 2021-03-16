using System;
using System.Linq;

namespace IS413_GroupProject.Models
{
    public class EFTourRepository : iTourRepository
    {

        private TourDbContext _context;

        public EFTourRepository (TourDbContext context)
        {
            _context = context;
        }

        public IQueryable<Tour> Tours => _context.Tours;
    }
}
