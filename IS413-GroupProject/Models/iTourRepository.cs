using System;
using System.Linq;
namespace IS413_GroupProject.Models
{
    //Interface that is used as a template for EFTourRepository

    public interface iTourRepository
    {
        IQueryable<Tour> Tours { get; }

        IQueryable<Group> Groups { get; }
    }
}
