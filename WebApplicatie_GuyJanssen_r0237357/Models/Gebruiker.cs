using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicatie_GuyJanssen_r0237357.Models
{
    [Table("Gebruiker")]
    public class Gebruiker : IdentityUser
    {
        
        
        public string Voornaam { get; set; }
        public string Familienaam { get; set; }     
        public bool Geslacht { get; set; }

        //Navigation Properties
        public List<Favoriet> Favorieten { get; set; }
        
    }
}
