using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShowdeBola.Models
{
    public class Actor
    {
        public int Id {get; set;}
        [StringLength(100), Required, Display(Name = "Nome do ator")]
        public string Name {get; set;}
        [Display(Name = "Nome do filme")]
        public int MovieId {get; set;}

        public Movie movie {get; set;}

    }
}