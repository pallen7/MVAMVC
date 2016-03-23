using System;
using System.ComponentModel.DataAnnotations;

namespace MVAMVC.Models
{
    public class Person
    {
        [Required]
        [StringLength(10, MinimumLength = 2)]
        public string first_name { get; set; }

        [Required]
        public string surname { get; set; }

        [Required]
        public DateTime birthdate { get; set; }
    }
}
