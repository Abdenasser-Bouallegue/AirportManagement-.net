// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;


// Plane p2 = new Plane('Airbus',22, 03, 2023,32);
//Passenger p1 = new Passenger { FirstName = "abdenasser", LastName = "bouallegue", EmailAddress = "test@gmail.com" };
////Console.WriteLine(p1.CheckProfile("abdenasser", "bouallegue"));
////Console.WriteLine(p1.CheckProfile("abdenasser", "bouallegue", "test22@gmail.com"));
//Staff s1 = new Staff { FirstName = "staff1", LastName = "staff1" };
//Traveller t1 = new Traveller { FirstName = "trav1", LastName = "trav2" };
//p1.PassengerType();
//s1.PassengerType();
//t1.PassengerType();
ServiceFlight sf = new ServiceFlight();
sf.Flights = TestData.listFlights;
//foreach (var item in sf.GetFlightDates("Madrid"))
//{
//    Console.WriteLine(item);
//}
sf.GetFlights("Destination", "Paris");

