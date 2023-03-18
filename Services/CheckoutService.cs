using Microsoft.AspNetCore.Mvc;
using bookish;
using bookish.Models;
using Microsoft.EntityFrameworkCore;

namespace bookish.Services;
// Create interfaces

public interface ICheckoutActions
{
    List<Checkout> CheckoutsList();
    MyViewModel ViewCheckout();

}
// Class - To implement the interfaces
public class CheckoutActions : ICheckoutActions
{
    public List<Checkout> CheckoutsList()
    {
        var context = new BookishContext();
        var checkoutList = context.Checkout.Where(s => s.Returned == false).ToList();
        return (checkoutList);

    }

        public MyViewModel ViewCheckout()
    {
        using (var context = new BookishContext())
        {
            var booksName = context.Books.ToList();
            var membersName = context.Members.ToList();
            var listViewModel = new MyViewModel()
            {
                Books = booksName,
                Members = membersName,

            };
            return listViewModel;
        }
    }
}
