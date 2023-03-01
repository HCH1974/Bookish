using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using bookish.Models;

namespace bookish.Controllers;

public class MembersController : Controller
{

    [Route("Members")]
    public IActionResult Members()
    {
        var context = new BookishContext();
        //dispalys the list of books available in the database
        var memberList = context.Members.ToList();
        return View(memberList);
    }

    [HttpGet]
    public IActionResult AddMember()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SubmitAddMember(Members member)
    {
        using (var context = new BookishContext())
        {
            var newMember = new Members()
            {
                FirstName = member.FirstName,
                LastName = member.LastName,
                PhoneNo = member.PhoneNo,
                EmailId = member.EmailId,

            };
            context.Members.Add(newMember);
            context.SaveChanges();
        }
        return RedirectToAction("Members");
    }

}