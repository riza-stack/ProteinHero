using System;
using System.ComponentModel.DataAnnotations;

namespace ProteinHero.Models
{
    public class Person
    {
        [Required]
        [Display(Name = "Voornaam")]
        public string FirstName { get; set; }
        
        [Required]
        [Display(Name = "Achternaam")]
        public string LastName { get; set; }
        
        [Required]
        [Display(Name = "Email adres")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "telefoonnummer")]
        public string Phone { get; set; }
        [Required]
        [Display(Name = "Postcode")]
        public string Address { get; set; }
    }
}
