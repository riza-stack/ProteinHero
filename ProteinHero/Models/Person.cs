using System;
using System.ComponentModel.DataAnnotations;

namespace ProteinHero.Models
{
    public class Person
    {
        [Required(ErrorMessage = "gelieve uw voornaam in te vullen")]
        [Display(Name = "Voornaam")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "gelieve uw achternaam in te vullen")]
        [Display(Name = "Achternaam")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "gelieve uw E-mail in te vullen")]
        [Display(Name = "Email adres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefoonnummer is verplicht")]
        [Display(Name = "telefoonnummer")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Postcode is verplicht")]
        [Display(Name = "Postcode")]
        public string Address { get; set; }
    }
}
