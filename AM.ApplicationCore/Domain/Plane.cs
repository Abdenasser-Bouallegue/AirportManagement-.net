using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public enum PlaneType
    {
        Airbus, Boing
    }
    public class Plane
    {
        //public Plane(PlaneType planeType, DateTime manufactureDate, int capacity)
        //{
        //    PlaneType = planeType;
        //    ManufactureDate = manufactureDate;
        //    Capacity = capacity;
        //}
       
        public int PlaneId { get; set; }
        public PlaneType PlaneType { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int Capacity { get; set; }
        public ICollection<Flight> flights { get; set;}

        public override string? ToString()
        {
            return base.ToString();
        }
    }


}
