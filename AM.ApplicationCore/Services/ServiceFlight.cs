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
            //List<DateTime> ListDates = new List<DateTime>();
            //for (int i = 0; i < Flights.Count; i++)
            //{
            //    if (Flights[i].Destination == destination)
            //    {
            //        ListDates.Add(Flights[i].FlightDate);

            //    }

            //}
            //foreach (var flight in Flights)
            //{
            //    if (flight.Destination == destination)
            //    {
            //        ListDates.Add(flight.FlightDate);
            //    }
            //}
            var query1 = from Flight in Flights where Flight.Destination == destination select Flight.FlightDate;

         var query2 = Flights.Where(F => F.Destination == destination).Select(F => F.FlightDate);
             return query1.ToList();
     }
        public void ShowFlightDates(Plane plane)
        {
            var query = Flights.Where(elt => elt.Plane == plane).Select(elt => new
            {
                destination = elt.Destination,
                flightDate = elt.FlightDate,
            });
            var querySimple= from Flight in Flights
                             where Flight.Plane == plane
                             select new
                             {
                                 Flight.Destination,
                                 Flight.FlightDate
                             };
            foreach (var f in query)
            {
                Console.WriteLine(f.destination + " "+f.flightDate);
            }
        }
        public int ProgrammedFlightNumber (DateTime startDate)
        {
            var query=Flights.Where(f=>DateTime.Compare(f.FlightDate, startDate)>0 && (f.FlightDate-startDate).TotalDays<=7).Count() ;
            return query;
        }
        public double DurationAverage(string destination)
        {
            var query= (from flight in Flights where flight.Destination == destination select flight.EstimatedDuration).Average();
            return query;
        }
        
        public List<Flight> OrderedDurationFlights()
        {
            var query = (from flight in Flights orderby flight.EstimatedDuration descending 
                         select flight).ToList();
            return query;
        }
        //
        public List<Traveller> SeniorTravellers(Flight flight)
        {
            var query = (from p in flight.Passengers.OfType<Traveller>()

                         orderby p.BirthDate
                         select p).Take(3).ToList();
            return query;
            var query2 = flight.Passengers.OfType<Traveller>().OrderBy(p => p.BirthDate).Take(3).ToList();
            return query;
        }
        public IEnumerable<IGrouping<string,Flight>> DestinationGroupedFlights()
        {
            var query = from flight in Flights
                        group flight by flight.Destination;
           
            var query2 = Flights.GroupBy(f => f.Destination);    
            foreach (var grouping in query2)
            {
                Console.WriteLine("Destination "+ grouping.Key);
                foreach(var flight in grouping)
                {
                    Console.WriteLine("Decollage"+flight.FlightDate);
                }
            }
            return query;
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
