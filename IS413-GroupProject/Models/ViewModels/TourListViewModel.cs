using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IS413_GroupProject.Models.ViewModels
{
    public class TourListViewModel
    {
       public IEnumerable<Tour> Tours { get; set; }

        public PagingInfo PagingInfo { get; set; }

        //additional attribute to help get the category I want
        //public string CurrentCategory { get; set; }
    }
}
