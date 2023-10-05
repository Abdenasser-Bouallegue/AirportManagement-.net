using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight : IServiceFlight
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();

        public List<DateTime> GetFlightDates(string destination)
        {
            List<DateTime> ListDates = new List<DateTime>();
            //for (int i = 0; i < Flights.Count; i++)
            //{
            //    if (Flights[i].Destination == destination)
            //    {
            //        ListDates.Add(Flights[i].FlightDate);

            //    }

            //}
            foreach (var flight in Flights)
            {
                if (flight.Destination == destination)
                {
                    ListDates.Add(flight.FlightDate);
                }
            }
            return ListDates;
        }

        public void GetFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {
                case "Destination":
                    foreach (var flight in Flights)
                    {
                        if (flight.Destination == filterValue)
                        {
                            Console.WriteLine(flight.ToString());
                        }
                    }

                    break;
                case "FlightDate":
                    foreach (var flight in Flights)
                    {
                        if (flight.FlightDate == DateTime.Parse(filterValue))
                        {
                            Console.WriteLine(flight.ToString());
                        }

                    }
                    break;
                case "EffectiveArrival":
                    foreach (var flight in Flights)
                    {
                        if (flight.EffectiveArrival == DateTime.Parse(filterValue))
                        {
                            Console.WriteLine(flight.ToString());
                        }

                    }
                    break;
                default: Console.WriteLine("vol non trouver");
                    break;
            }
        }
    }
}
