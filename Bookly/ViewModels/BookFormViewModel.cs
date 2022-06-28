using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using Bookly.Models;

namespace Bookly.ViewModels
{
    public class BookFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }
        [Required(ErrorMessage = "* Please enter the book title.")]
        [StringLength(255)]
        public string Name { get; set; }


        [Required(ErrorMessage = "* Please enter the author.")]
        [StringLength(255)]
        public string Author { get; set; }

        [Required(ErrorMessage = "* Please select a genera.")]
        [Display(Name = "Genre")]
        public byte? GenreId { get; set; }

        [Required(ErrorMessage = "* Please set a release date. (d/mmm/yyyy)")]
        [Display(Name = "Release date")]
        public DateTime? ReleaseDate { get; set; }

        [Required(ErrorMessage = "* Please specify the number of stock")]
        [Display(Name = "# in Stock")]
        [Range(1, 999)]
        public byte? NumberInStock { get; set; }
        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Book" : "New Book";

            }
        }

        public BookFormViewModel()
        {
            Id = 0;
        }

        public BookFormViewModel(Book book)
        {
            Id = book.Id;
            Name = book.Name;
            Author = book.Author;
            ReleaseDate = book.ReleaseDate;
            NumberInStock = book.NumberInStock;
            GenreId = book.GenreId;
        }
    }
}
