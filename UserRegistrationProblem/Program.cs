using System;
using System.Text.RegularExpressions;

namespace RegexAssignment
{
    internal class UserRegistration
    {
        public string FirstName { get; set; }


        public void AcceptRecord()
        {
            Console.Write("Enter your First Name (1st Letter should be Capital) : ");
            this.FirstName = Console.ReadLine();
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
