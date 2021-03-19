using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

//table for all the info necessary to create a Tour/appointment object

namespace IS413_GroupProject.Models
{
    public class Tour
    {
        [Required]
        [Key]
        public int TourId { get; set; }

        [Required]
        public DateTime AppointmentDate { get; set; }

        [Required]
        public string TourType { get; set; }

        [Required]
        public int GroupSize { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Language { get; set; }

        [Required]
        public bool Available { get; set; } = true;
        
    }
}
