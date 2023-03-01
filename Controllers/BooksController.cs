using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bookish.Models;

namespace bookish.Controllers;

public class BooksController : Controller
{

    // [Route("Books")]
    public IActionResult Books()
    {
        var context = new BookishContext();
        //dispalys the list of books available in the database
        var bookList = context.Books.ToList();
        return View(bookList);
    }

    // public void AddBook(Books newBook)
    // {

    //     using (var context = new BookishContext())
    //     {
    //         //var book = new Books("Harry Potter", "J.K.Rowling", 5, 10);
    //         context.Books.Add(newBook);
    //         context.SaveChanges();
    //     }
    // }
}