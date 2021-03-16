using System;
using System.ComponentModel.DataAnnotations;

namespace IS413_GroupProject.Models
{
    public class Tour
    {
        [Required]
        [Key]
        public int TourId { get; set; }

        [Required]
        public DateTime TourTime { get; set; }

        [Required]
        public string TourType { get; set; }

    }
}
