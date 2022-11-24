using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicatie_GuyJanssen_r0237357.Models
{
    [Table("Gebruiker")]
    public class Gebruiker : IdentityUser
    {
        [Key]
        public int GebruikerId { get; set; }
        public string Voornaam { get; set; }
        public string Familienaam { get; set; }
        public string Email { get; set; }
        public string Wachtwoord { get; set; }
        public string Gebruikersnaam { get; set; }
        public string Rol { get; set; }
        public bool Geslacht { get; set; }

        //Navigation Properties
        public List<Favoriet> Favorieten { get; set; }
        
    }
}
