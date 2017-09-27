using _14DTHC1_2.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace _14DTHC1_2.Controllers
{
    public class BookController : Controller
    {
        private List<Book> listBooks;

        public BookController()
        {
            this.listBooks = new List<Book>();
            //Push data
            listBooks.Add(new Book()
            {
                BookId = 1,
                Title = "Dac Nhan Tam",
                Author = "DC",
                Year = 2012,
                Cover = "Content/images/book-1.png"
            });
            listBooks.Add(new Book()
            {
                BookId = 2,
                Title = "Pro ASP .NET MVC",
                Author = "Freeman, Adam",
                Year = 2013,
                Cover = "Content/images/book-2.png"
            });
            listBooks.Add(new Book()
            {
                BookId = 3,
                Title = "Clean Code",
                Author = "...",
                Year = 2010,
                Cover = "Content/images/book-3.png"
            });
        }
        // GET: Book
        //No View
        public string HelloController(string info)
        {
            return "Hello first controller!" + info;
        }
        //View
        //Get: Books
        public ActionResult GetListBook()
        {
            return View("ListBook", listBooks);
        }

        //Edit Book
        public ActionResult Edit(int id)
        {
            Book book = listBooks.Find(s => s.BookId == id);
            return View(book);
        }

        //Post book
        [HttpPost]
        public ActionResult Edit(Book book)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Giá trị nhập không hợp lệ!");
                return View(book);
            }
            //update book
            Book b = listBooks.Find(s => s.BookId == book.BookId);
            if (b == null)
                return HttpNotFound();

            b.Title = book.Title;
            b.Author = book.Author;
            b.Year = book.Year;
            b.Cover = book.Cover;
            return View("ListBook", listBooks);
        }
    }
}