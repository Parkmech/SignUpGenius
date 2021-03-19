using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IS413_GroupProject.Models.ViewModels
{
    public class TourListViewModel
    {
       public IEnumerable<Tour> Tours { get; set; }

        public IEnumerable<Group> Groups { get; set; }

        public PagingInfo PagingInfo { get; set; }

        //additional attribute to help get the category I want could be placed here; because we're not worried about it for Project1, I left it blank
        //public string CurrentCategory { get; set; }
    }
}
