using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bookish.Models;

namespace bookish.Controllers;

public class CheckoutController : Controller
{

    
    [HttpGet]
    public IActionResult CheckoutBook(Books book)
    {
       
        return View();
    }

    [HttpPost]
    public IActionResult Checkout(Checkout check)
    {
        using (var context = new BookishContext())
        {
            var checkout  = new Checkout()
            {
                MemberId = check.MemberId,
                BookId= check.BookId
            };
            context.Checkout.Add(checkout);
            context.SaveChanges();
        }
        return RedirectToAction("Books");
    }

}