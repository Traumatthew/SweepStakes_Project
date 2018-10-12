using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    static class UserInterface
    {
        public static Contestant GetUserInput(Contestant contestant)
        {
            Console.WriteLine("Please enter your first name.");
            contestant.firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name.");
            contestant.lastName = Console.ReadLine();
            Console.WriteLine("Please enter you Email address.");
            contestant.emailAddress = Console.ReadLine();
            return contestant;
        }

        public static int AssignRegistrationNumber()
        {
            return 0;
        }
    }
}
