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
        var bookList = context.Books.ToList();
        return View(bookList);
    }

    // public void AddBooks()
    // {
    //     using (var context = new BookishContext())
    //     {
    //         var book = new Books("Harry Potter", "J.K.Rowling", 5, 10);
    //         context.Books.Add(book);
    //         context.SaveChanges();
    //     }
    // }

    // public void ViewBooks()
    // {

    // }

    // public static string GetName()
    // {
    //     return "Bill";
    // }

}