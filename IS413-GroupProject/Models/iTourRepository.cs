using System;
using System.Linq;
namespace IS413_GroupProject.Models
{
    public interface iTourRepository
    {
        IQueryable<Tour> Tours { get; }

        IQueryable<Group> Groups { get; }
    }
}
