using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bookish.Models;
using bookish.Services;
using Microsoft.EntityFrameworkCore;

namespace bookish.Controllers;

public class CheckoutController : Controller
{
    private readonly ICheckoutActions _ICheckoutActions;
    public CheckoutController(ICheckoutActions checkoutAction)
    {
        _ICheckoutActions = checkoutAction;
    }

    [HttpGet]
    public IActionResult CheckoutBook()
    {
        var listViewModel = _ICheckoutActions.ViewCheckout();
        return View(listViewModel);

    }

    [Route("Books")]
    [HttpPost]
    public IActionResult Checkout(int bookId, int memberId)
    {
        using (var context = new BookishContext())
        {
            var selectedBook = context.Books.FirstOrDefault(x => x.Id == bookId);
            if (selectedBook != null)
            {
                selectedBook!.AvailableCopies -= 1;

            }
            var checkout = new Checkout()
            {
                MemberId = memberId,
                BookId = bookId
            };
            context.Checkout.Add(checkout);
            context.SaveChanges();
        }

        //     var result = context.Books.SingleOrDefault(b => b.BookName == "another one");
        //     if (result != null)
        //     {
        //         try
        //         {
        //             result.AvailableCopies -= 1;
        //             context.Books.Attach(result);
        //             context.Entry(result).State = EntityState.Modified;
        //             context.SaveChanges();
        //         }
        //         catch (Exception ex)
        //         {
        //             throw;
        //         }

        //         var checkout = new Checkout()
        //         {
        //             MemberId = 100,
        //             BookId = 200
        //         };
        //         context.Checkout.Add(checkout);
        //         context.SaveChanges();
        //     }
        return Redirect("Books");
    }

    [Route("Checkouts")]
    [HttpGet]
    public IActionResult ListCheckouts()
    {
        var checkoutList = _ICheckoutActions.CheckoutsList();
        return View(checkoutList);
    }

    [Route("Checkouts")]
    [HttpPost]
    public IActionResult Checkin(int Id)
    {
        Console.WriteLine("I've been clicked");
        Console.WriteLine(Id);

        using (var context = new BookishContext())
        {

            var resultCheckout = context.Checkout.SingleOrDefault(c => c.Id == Id);
            resultCheckout.Returned = true;

            var resultBook = context.Books.SingleOrDefault(b => b.Id == resultCheckout.BookId);

            resultBook.AvailableCopies += 1;
            context.Books.Attach(resultBook);
            context.Entry(resultBook).State = EntityState.Modified;
            context.SaveChanges();
        }

        return RedirectToAction("ListCheckouts");
    }

}