using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bookish.Models;

namespace bookish.Controllers;

public class CheckoutController : Controller
{
    [HttpGet]
    public IActionResult CheckoutBook()
    {
        using (var context = new BookishContext())
        {
            var booksName = context.Books.Select(p => p.BookName).ToList();
            var membersName = context.Members.Select(p => p.FirstName).ToList();
            var listViewModel = new MyViewModel()
            {
                BookName = booksName,
                MemberName = membersName

            };
            return View(listViewModel);
        }
    }

    [Route("Books")]
    [HttpPost]
    public IActionResult Checkout(Checkout check)
    {
        using (var context = new BookishContext())
        {
            var checkout = new Checkout()
            {
                MemberId = check.MemberId,
                BookId = check.BookId
            };
            context.Checkout.Add(checkout);
            context.SaveChanges();
        }
        return Redirect("Books");
    }

}