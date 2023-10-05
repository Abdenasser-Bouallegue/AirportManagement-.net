using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
       
    {
        public DateTime BirthDate { get; set; }
        public string PassportNumber { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TelNumber { get; set; }
        public Flight Flight { get; set; }

        public override string? ToString()
        {
            return base.ToString();
        }
        public bool CheckProfile(string firstname , string lastname)
        {
            return firstname == FirstName && lastname == LastName;

        }
        public bool CheckProfile(string firstname, string lastname , string email)
        {
            return firstname == FirstName && lastname == LastName && email==EmailAddress;

        }
        public virtual void PassengerType() {
            Console.WriteLine("je suis un passager");

        }
    }

}
