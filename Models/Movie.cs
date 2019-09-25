using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [Display(Name ="Release Date")]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        [Column(TypeName ="decimal(13,2)")]
        public decimal Price { get; set; }
        public string Rating { get; set; }
    }
}