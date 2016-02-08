using Nancy;
using Letter.Objects;

namespace FriendLetter
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/form"] = _ => {
        return View["form.html"];
      };
      Get["/hello"] = _ => {
        LetterVariables myLetterVariables = new LetterVariables
        {
          Sender = Request.Query["sender"],
          Recipient = Request.Query["recipient"]
        };
        return View["hello.html", myLetterVariables];
      };
    }
  }
}
