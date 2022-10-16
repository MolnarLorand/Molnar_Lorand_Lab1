using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Molnar_Lorand_Lab1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello");
        }


        public IActionResult Greeting()
        {
            String greeting = "Salut";

            return Content(greeting);
        }

        public IActionResult Test(int number, String Name)
        {

            return Content("t- "+number+" "+Name);
        }


        
        
    }
}
