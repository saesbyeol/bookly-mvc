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
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        // DISPOSING THE OBJECT
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
         
        // ADD NEW CUSTOMER
        // GET: Customers/new
        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new NewCustomerViewModel
            {
                MembershipTypes = membershipTypes
            };
            return View(viewModel);
        }

        // CREATE NEW CUSTOMER
        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }

        // GET: Customers
        public ActionResult Index()
        {
            // GET CUSTOMERS FROM DB
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }

        // SEE CUSTOMER DETAILS
        // GET: Customers/details/id
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }
    }
}