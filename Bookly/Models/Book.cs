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


        [StringLength(255)]
        [Display(Name = "Book Title")]
        public string Name { get; set; }


        [Required(ErrorMessage = "* Please enter the author.")]
        [StringLength(255)]
        [Display(Name = "Author")]
        public string Author { get; set; }

        public Genre Genre { get; set; }

        [Required(ErrorMessage = "* Please select a genera.")]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }
        public DateTime? DateAdded { get; set; }

        [Display(Name = "Date of Release")]
        public DateTime? ReleaseDate { get; set; }


        [Display(Name = "Stock #")]
        [Range(1,999)]
        public byte NumberInStock { get; set; }
        public byte NumberAvailable { get; set; }

        /* TODO:
         - ADD PICTURE
         - ADD SHORT BIO
         - ADD BOOK CONDITION

        */

    }
}