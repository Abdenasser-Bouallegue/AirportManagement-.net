using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AM.ApplicationCore.Domain;

namespace AM.ApplicationCore.Interfaces
{
    public interface IServicePlane
    {
        public void Add(Plane p);
        public void Save();
        public IList<Plane> GetAll();
    }
}
