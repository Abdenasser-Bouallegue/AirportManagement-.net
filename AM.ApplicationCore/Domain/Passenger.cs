using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
       
    {
        public int Id { get; set; }
       
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime BirthDate { get; set; }
       
        [StringLength(7)]
        public string PassportNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        [MinLength(3, ErrorMessage ="firstname must be more than 3 carracteres")]
        [MaxLength(25, ErrorMessage = "firstname must be Less than 25 carracteres")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.PhoneNumber)]
        public int TelNumber { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }

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
