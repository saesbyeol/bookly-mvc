using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Bookly.Dtos;
using Bookly.Models;

namespace Bookly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        // INIT DB
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        // POST: Customer + Movie to Db
        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            var customer = _context.Customers.Single(
                c => c.Id == newRental.CustomerId);

            // SELECT * FROM Movies WHERE Id IN (1, 2, 3)
            var books = _context.Books.Where(
                b => newRental.BookIds.Contains(b.Id)).ToList();

            foreach (var book in books)
            {
                // ANTI-TAMPER PROTECTION
                if (book.NumberAvailable == 0)
                    return BadRequest("Book not Available!");

                book.NumberAvailable--;
                var rental = new Rental
                {
                    Customer = customer,
                    Book = book,
                    DateRented = DateTime.Now
                };
                _context.Rentals.Add(rental);
            }
            _context.SaveChanges();

            return Ok();
        }

    }
}