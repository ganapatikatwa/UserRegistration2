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

        //UC3 Email
        public void ValidEmail()
        {
            Console.WriteLine("Please Enter Email");
            string data = Console.ReadLine();
            string pattern = "^[a-zA-Z]{3,}([.][a-zA-Z]{3,})[@][a-z]{2}[.][a-z]{2,}([.][a-z]{2})$";

            Regex regobj = new Regex(pattern);
            if (regobj.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Email is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Email Is Invalid");
                Console.ResetColor();
            }
        }
        //UC4 Email
        public void ValidPhNumber()
        {
            Console.WriteLine("Please Enter Mobile Number");
            string data = Console.ReadLine();
            string pattern = "^[0-9]{2}[ ]{1}[6-9]{1}[0-9]{9}$";

            Regex regobj = new Regex(pattern);
            if (regobj.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Mobile Number is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Mobile Number Is Invalid");
                Console.ResetColor();
            }
        }
        //UC5 PassWord Rule-1
        public void ValidPasswordRule1()
        {
            Console.WriteLine("Please Enter Password Rule 1");
            string data = Console.ReadLine();
            string pattern = "^[a-zA-Z]{8,}$";

            Regex regobj = new Regex(pattern);
            if (regobj.IsMatch(data))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Password Rule 1 is Valid");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Password Rule 1 Is Invalid");
                Console.ResetColor();
            }
        }
    }
}
