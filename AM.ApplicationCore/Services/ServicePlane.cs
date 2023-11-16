using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AM.ApplicationCore.Services
{
    public class ServicePlane : IServicePlane
    {
      //  private IGenericRepository<Plane> _repository;
      private IUnitOfWork unitOfWork;
        public ServicePlane(IUnitOfWork _unitOfWork)
        {
          //  this._repository = repository;
          this.unitOfWork = _unitOfWork;
        }
        public void Add(Plane p)
        {
          // _repository.Add(p);
         unitOfWork.Repository<Plane>().Add(p);
        }

        public IList<Plane> GetAll()
        {
            //return _repository.GetAll().ToList();
         return   unitOfWork.Repository<Plane>().GetAll().ToList();
        }

        public void Save()
        {
           //_repository.SubmitChanges();
           unitOfWork.Save();
        }
    }
}
