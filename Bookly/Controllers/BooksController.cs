using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bookly.Models;
using Bookly.ViewModels;

namespace Bookly.Controllers
{
    public class BooksController : Controller
    {
        private ApplicationDbContext _context;
        public BooksController()
        {
            _context = new ApplicationDbContext();
        }

        // DISPOSING THE OBJECT
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var books = _context.Books.Include(b => b.Genre).ToList();
            return View(books);
        }

        // SEE BOOK DETAILS
        // GET: Books/details/id
        public ActionResult Details(int id)
        {
            var book = _context.Books.Include(b => b.Genre).SingleOrDefault(b => b.Id == id);
            if (book == null)
                return HttpNotFound();

            return View(book);
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