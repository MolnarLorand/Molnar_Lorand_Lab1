using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Molnar_Lorand_Lab1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public String Greeting()
        {
            String greering = "Salut";

            return greering;
        }

        public String Test(int number, String Name)
        {
            number = 10;
            Name = "Test";

            Console.WriteLine($"Hello, {Name},{number}");
            return "mesaj"+number+" "+Name;
        }


        
        
    }
}
