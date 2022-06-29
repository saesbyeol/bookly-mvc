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
            return View();
        }

        // ADD NEW BOOK
        // GET: Books/new
        public ViewResult New()
        {
            var genres = _context.Genres.ToList();
            var viewModel = new BookFormViewModel
            {
                Genres = genres
            };

            return View("BookForm", viewModel);
        }

        // CREATE NEW BOOK
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Book book)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new BookFormViewModel(book)
                {
                    Genres = _context.Genres.ToList()
                };
                return View("BookForm", viewModel);
            }


            if (book.Id == 0)
                _context.Books.Add(book);
            else
            {
                var bookInDb = _context.Books.Single(b => b.Id == book.Id);

                bookInDb.Name = book.Name;
                bookInDb.Author = book.Author;
                bookInDb.ReleaseDate = book.ReleaseDate;
                bookInDb.DateAdded = book.DateAdded;
                bookInDb.GenreId = book.GenreId;
                bookInDb.NumberInStock = book.NumberInStock;


            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Books");
        }

        // EDIT BOOK DETAILS
        // GET: Books/edit/id
        public ActionResult Edit(int id)
        {
            var book = _context.Books.SingleOrDefault(c => c.Id == id);

            if (book == null)
                return HttpNotFound();

            var viewModel = new BookFormViewModel(book)
            {
                Genres = _context.Genres.ToList()
            };

            return View("BookForm", viewModel);

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