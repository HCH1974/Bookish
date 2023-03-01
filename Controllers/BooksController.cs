using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bookish.Models;

namespace bookish.Controllers;

public class BooksController : Controller
{

    [Route("Books")]
    public IActionResult Books()
    {
        var context = new BookishContext();
        //dispalys the list of books available in the database
        var bookList = context.Books.ToList();
        return View(bookList);
    }

    [HttpGet]
    public IActionResult AddBook()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SubmitAddBook(Books book)
    {
        using (var context = new BookishContext())
        {
            var newBook = new Books()
            {
                BookName = book.BookName,
                AuthorName = book.AuthorName,
                TotalNoOfCopies = book.TotalNoOfCopies,
                AvailableCopies = book.TotalNoOfCopies
            };
            context.Books.Add(newBook);
            context.SaveChanges();
        }
        return RedirectToAction("Books");
    }

     [HttpPost]
    public IActionResult CheckoutBook(Books book)
    {
       
        return RedirectToAction("Members");
    }

}