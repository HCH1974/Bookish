namespace bookish.Models;

public class Checkout
{

    public int Id {get; set;}
    public int MemberId { get; set; }
    public int BookId { get; set; }
    public int CheckoutDate { get; set; }
    public int ReturnDate { get; set; }
    public bool Returned {get; set;}

    public Checkout(int id, int memberId,int  bookId, int checkoutDate, int returnDate, bool returned){

        Id = id;
        MemberId = memberId;
        BookId = bookId;
        CheckoutDate = checkoutDate;
        ReturnDate = returnDate;
        Returned = returned;

    }

}