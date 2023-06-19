using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_UserRegistration
{
    public class UserRegistration
    {
        //UC1 First Name
        public void ValidFirstName()
        {
            Console.WriteLine("Please Enter First Name");
            string data = Console.ReadLine();
            string pattern = "^[A-Z]{1}[a-z]{2,10}$";

            Regex regobj = new Regex(pattern);
            if(regobj.IsMatch(data))
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("First Name is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("First Name Is Invalid");
                Console.ResetColor();
            }
        }

        //UC2 First Name
        public void ValidLastName()
        {
            Console.WriteLine("Please Enter Last Name");
            string data = Console.ReadLine();
            string pattern = "^[A-Z]{1}[a-z]{2,10}$";

            Regex regobj = new Regex(pattern);
            if (regobj.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Last Name is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Last Name Is Invalid");
                Console.ResetColor();
            }
        }
    }
}
