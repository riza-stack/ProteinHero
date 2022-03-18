using System;
using System.ComponentModel.DataAnnotations;

namespace ProteinHero.Models
{
    public class Person
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        
        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
        [Required]
        public string Address { get; set; }
        public string Description { get; set; }
    }
}
