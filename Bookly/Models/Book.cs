using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bookly.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Book Title")]
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        [Display(Name = "Author")]

        public string Author { get; set; }
        public Genre Genre { get; set; }
        [Display(Name = "Genre")]
        [Required]

        public byte GenreId { get; set; }

        public DateTime? DateAdded { get; set; }
        [Display(Name = "Date of Release")]
        public DateTime? ReleaseDate { get; set; }
        [Display(Name = "Stock #")]

        // CHANGE TO INT LATER
        public byte NumberInStock { get; set; }

        /* TODO:
         - ADD PICTURE
         - ADD SHORT BIO
         - ADD BOOK CONDITION

        */

    }
}