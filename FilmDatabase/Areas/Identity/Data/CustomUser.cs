using FilmDatabase.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FilmDatabase.Areas.Identity.Data
{
	public class CustomUser : IdentityUser
	{
		

        [PersonalData]
        public string Voornaam { get; set; }
        [PersonalData]
        public string Familienaam { get; set; }
        [PersonalData]
        public bool Geslacht { get; set; }
        
        [PersonalData]
        [DataType(DataType.Date)]
        public DateTime? Geboortedatum { get; set; }


        //Navigation Properties
        public List<Favoriet> Favorieten { get; set; }
    }
}
