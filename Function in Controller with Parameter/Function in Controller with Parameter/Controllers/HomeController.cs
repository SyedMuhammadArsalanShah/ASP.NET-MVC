using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Function_in_Controller_with_Parameter.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public String  Index()
        {  
           return "Demo";
        }
        public String IndexEvenOdd(int id)
        {
            if (id % 2 ==0 )
            {

                return "even";
            }
            else {
                return "odd";
            }
       
        }
        public String IndexLeapYear(int id)
        {
            if (id % 4 == 0)
            {

                return "Leap Year";
            }
            else
            {
                return "Is not Leap Year";
            }

        }
        public String IndexFactorial(int id)
        {
            int fact=1;
            for (int i = 1  ; i <= id; i++)
            {
                fact *= i; // fact = fact * i;
            }
            return fact.ToString();
        }
    }
}