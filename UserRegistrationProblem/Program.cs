using System;
using System.Text.RegularExpressions;

namespace RegexAssignment
{
    internal class UserRegistration
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public void AcceptRecord()
        {
            Console.Write("Enter your First Name (1st Letter should be Capital) : ");
            this.FirstName = Console.ReadLine();

            Console.Write("Enter your Last Name (1st Letter should be Capital) : ");
            this.LastName = Console.ReadLine();
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

        }
        static void Main() 
        {
            UserRegistration user = new UserRegistration();
            user.AcceptRecord();
            user.CheckRegex();
        }
    }
}
