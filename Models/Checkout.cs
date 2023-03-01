using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bookish.Models;

public class Checkout
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [ForeignKey("Members")]
    public int MemberId { get; set; }
    [ForeignKey("Books")]
    public int BookId { get; set; }
 // [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public static DateTime CheckoutDate { get; set; } = DateTime.Now;
    public static DateTime ReturnDate { get; set; } = CheckoutDate.AddDays(30);
    public bool Returned { get; set; } = false;

    public Checkout(){}
}