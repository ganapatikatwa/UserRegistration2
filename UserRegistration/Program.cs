using Regex_UserRegistration;
using System;

namespace REGEX_UserRegistration
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to REGEX User Registration Problem");

            Console.WriteLine("Select Options Please :\n" +
                "1)Enter First Name\n2)Enter Last Name\n3)Enter Email\n4)Phone Number\n5)Password Rule1" +
                "\n6)Password Rule2");

            int option = Convert.ToInt32(Console.ReadLine());
            UserRegistration user = new UserRegistration();
            switch (option)
            {
                case 1:
                    user.ValidFirstName();
                    break;
                case 2:
                    user.ValidLastName();
                    break;
                case 3:
                    user.ValidEmail();
                    break;
                case 4:
                    user.ValidPhNumber();
                    break;
                case 5:
                    user.ValidPasswordRule1();
                    break;
                case 6:
                    user.ValidPasswordRule2();
                    break;
                default:
                    Console.WriteLine("Choose Proper options");
                    break;
            }
        }
            
        
    }
}