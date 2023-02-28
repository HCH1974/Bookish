namespace bookish.Models;

public class Books
{

    public int Id {get; set;}
    public string BookName { get; set; }
    public string AuthorName { get; set; }
    public int AvailableCopies { get; set; }
    public int TotalNoOfCopies { get; set; }

    public Books(int id, string bookName,string authorName,int availableCopies, int totalNoOfCopies){
//int primary key auto_increment
        Id = id;
        BookName = bookName;
        AuthorName = authorName;
        AvailableCopies = availableCopies;
        TotalNoOfCopies = totalNoOfCopies;
        
    }

}