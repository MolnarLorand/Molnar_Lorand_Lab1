using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Molnar_Lorand_Lab1.Controllers
{
    public class TestController : Controller
    {
        public String Index()
        {
            return "Hello";
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

            return "t- "+number+" "+Name;
        }


        
        
    }
}
