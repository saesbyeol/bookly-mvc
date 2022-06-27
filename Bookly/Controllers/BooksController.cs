using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bookly.Models;
using Bookly.ViewModels;

namespace Bookly.Controllers
{
    public class BooksController : Controller
    {


        public ViewResult Index()
        {
            var movies = GetBooks();
            return View(movies);
        }
        private IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book { Id = 1, Name = "The Ballad of the Empty throne" },
                new Book { Id = 2, Name = "Cum" }
            };
        }


        //GET: Books/Random
        public ActionResult Random()
        {
            var book = new Book() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}

            };
            var viewModel = new RandomBookViewModel
            {
                Book = book,
                Customers = customers
            };

            return View(viewModel);
        }

    }
}