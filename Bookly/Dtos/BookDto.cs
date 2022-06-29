using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Bookly.Models;

namespace Bookly.Dtos
{
    public class BookDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "* Please enter the book name.")]
        [StringLength(255)]
        public string Name { get; set; }


        [Required(ErrorMessage = "* Please enter the author.")]
        [StringLength(255)]
        public string Author { get; set; }


        [Required(ErrorMessage = "* Please select a genera.")]
        public byte GenreId { get; set; }

        public DateTime? DateAdded { get; set; }
        public DateTime? ReleaseDate { get; set; }

        [Range(1, 999)]
        // CHANGE TO INT LATER
        public byte NumberInStock { get; set; }
    }
}