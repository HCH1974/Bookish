namespace bookish.Models;

public class Members
{
    public int Id { get; set; }
    public string MemberName { get; set; }
    public int PhoneNo { get; set; }
    public string EmailId { get; set; }

    public Members(int id, string memberName, int phoneNo, string emailId)
    {
        Id = id;
        MemberName = memberName;
        PhoneNo = phoneNo;
        EmailId = emailId;

    }
}