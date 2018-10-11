using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    public class Contestant
    {
        // Member Variables

        public string firstName;
        public string lastName;
        public string email;
        public string address;
        public int registrationNumber;

        public Contestant(string contestantFirstName, string contestantLastName, string contestantEmail, string contestantAddress, int contestantRegistrationNumber)
        {
            firstName = contestantFirstName;
            lastName = contestantLastName;
            email = contestantEmail;
            address = contestantAddress;
            registrationNumber = contestantRegistrationNumber;

        }
    }
}
