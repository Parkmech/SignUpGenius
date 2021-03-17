using System;
using System.ComponentModel.DataAnnotations;

namespace IS413_GroupProject.Models
{
    public class Group
    {
        [Key]
        public int GroupId { get; set; }

        [Required]
        public string GroupName { get; set; }

        [Required]
        public int NumPeople { get; set; }

        [Required]
        public string Email { get; set; }

        public string PhoneNum { get; set; }
    }
}
