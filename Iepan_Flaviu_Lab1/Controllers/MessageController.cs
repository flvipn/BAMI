using Microsoft.AspNetCore.Mvc;

namespace Iepan_Flaviu_Lab1.Controllers
{
    public class MessageController : Controller
    {
        public ActionResult<string> Index()
        {
            return "Welcome user!";
        }
        public ActionResult<string> WelcomeWithHello()
        {
            return "Hello and welcome user!"; 
        }
        public ActionResult<string> NameText(string text, int number)
        {
            return $"Hello {text}, your number is: {number}!";
        }
    }
}
