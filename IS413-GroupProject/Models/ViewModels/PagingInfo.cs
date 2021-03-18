using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//this class creates a page class to get the attributes needed for pagination

namespace IS413_GroupProject.Models.ViewModels
{
    public class PagingInfo
    {
        public int TotalNumItems { get; set; }

        public int ItemsPerPage { get; set; }

        public int CurrentPage { get; set; }

        public int TotalPages => (int)(Math.Ceiling((decimal)TotalNumItems / ItemsPerPage));
    }
}
