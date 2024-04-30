using System;
using System.Text.RegularExpressions;

namespace RegexAssignment
{
    internal class UserRegistration
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }


        public void AcceptRecord()
        {
            Console.Write("Enter your First Name (1st Letter should be Capital) : ");
            this.FirstName = Console.ReadLine();

            Console.Write("Enter your Last Name (1st Letter should be Capital) : ");
            this.LastName = Console.ReadLine();

            Console.Write("Enter your Email : ");
            this.Email = Console.ReadLine();
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

        }
        static void Main() 
        {
            UserRegistration user = new UserRegistration();
            user.AcceptRecord();
            user.CheckRegex();
        }
    }
}
