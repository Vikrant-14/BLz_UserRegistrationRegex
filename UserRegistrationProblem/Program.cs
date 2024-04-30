using System;
using System.Text.RegularExpressions;

namespace RegexAssignment
{
    internal class UserRegistration
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }


        public void AcceptRecord()
        {
            Console.Write("Enter your First Name (1st Letter should be Capital) : ");
            this.FirstName = Console.ReadLine();

            Console.Write("Enter your Last Name (1st Letter should be Capital) : ");
            this.LastName = Console.ReadLine();

            Console.Write("Enter your Email : ");
            this.Email = Console.ReadLine();

            Console.Write("Enter phone number : ");
            this.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Password must contain minimun 8 characters,  atleast 1 Upper case, atleast 1 number, atleast 1 Special Character.");
            Console.Write("Enter password : ");
            this.Password = Console.ReadLine();
        }

        public void CheckRegex()
        {
            var namePattern = @"\b[A-Z]+\w{3,}";

            Regex reg1 = new Regex(namePattern);

            if(reg1.IsMatch(this.FirstName))
            {
                Console.WriteLine($"Your First Name : {this.FirstName}");
            }
            else
            {
                Console.WriteLine("Invalid First Name format!!!");
            }

            if (reg1.IsMatch(this.LastName))
            {
                Console.WriteLine($"Your Last Name : {this.LastName}");
            }
            else
            {
                Console.WriteLine("Invalid Last Name format!!!");
            }


            var emailPattern = @"[a-z].{5,}\d?@(gmail|yahoo|[a-z]+)+.(com|co|in|[a-z]{2,3})";

            Regex reg2 = new Regex(emailPattern);

            if (reg2.IsMatch(this.Email))
            {
                Console.WriteLine($"Your Email Id : {this.Email}");
            }
            else
            {
                Console.WriteLine("Invalid Email format!!!");
            }

            // var phonePattern = @"\b(\d{2}\s)?\d{10}\b";
            var phonePattern = @"\+\d{2}\s[0-9]{10}";

            Regex reg3 = new Regex(phonePattern);

            if (reg3.IsMatch(this.PhoneNumber))
            {
                Console.WriteLine($"Your Phone number : {this.PhoneNumber}");
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }

            var passwordPattern = @"(?=.*[A-Z])(?=.*[!@#$%^&*()])(?=.*[0-9]).{8,}";

            Regex reg4 = new Regex(passwordPattern);

            if (reg4.IsMatch(this.Password))
            {
                Console.WriteLine($"Your passowrd : {this.Password}");
            }
            else
            {
                Console.WriteLine("Invalid password");
            }

        }
        static void Main() 
        {
            UserRegistration user = new UserRegistration();
            user.AcceptRecord();
            user.CheckRegex();
        }
    }
}
