using Library.Data;
using Library.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Library.Controllers
{
    public class BookConnectionController : Controller
    {

        private readonly ApplicationDbContext _context;

        public BookConnectionController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: BookConnectionController
        public IActionResult Index(string SearchString)
        {
            ViewData["CurrentFilter"] = SearchString;
            var result = from c in _context.Customer
                         join bc in _context.BookConnections on c.CustomerId equals bc.FK_CustomerId into bookConnections
                         from bc in bookConnections.DefaultIfEmpty()
                         join b in _context.Book on bc.FK_BookId equals b.BookId into books
                         from b in books.DefaultIfEmpty()
                         select new BookConnection { Customer = c, Book = b };

            if (!String.IsNullOrEmpty(SearchString))
            {
                result = result.Where(bc => bc.Customer.Name.Contains(SearchString) ||
                                             bc.Book.Title.Contains(SearchString) ||
                                             bc.Book.Author.Contains(SearchString));
            }
            else
            {
                
                result = result.Where(bc => false);
            }

            return View(result);
        }

        public IActionResult Barrowed()
        {
            
            var bar = _context.BookConnections
                           .Where(b => b.IsReturned == false)
                           .Include(b => b.Customer)
                           .Include(b => b.Book)
                           .ToList();

            return View(bar);
        }

        public IActionResult Returned() 
        {
            var ret = _context.BookConnections
                           .Where(b => b.IsReturned == true)
                           .Include(b => b.Customer)
                           .Include(b => b.Book)
                           .ToList();

            return View(ret);

        }
    }
}
