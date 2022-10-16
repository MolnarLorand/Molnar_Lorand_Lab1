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
            String greeting = "Salut";

            return greeting;
        }

        public String Test(int number, String Name)
        {

            return "t- "+number+" "+Name;
        }


        
        
    }
}
