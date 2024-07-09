using ams.data.UnitOfWorks;
using ams.entity.Entities;
using ams.service.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ams.service.Services.Concretes
{
    public class ApartmentService : IApartmentService
    {
        private readonly IUnitOfWork Uow;

        public ApartmentService(IUnitOfWork uow)
        {
            Uow = uow;
        }

        public async Task<List<Apartment>> GetAllAsync()
        {
            var res = await Uow.GetRepository<Apartment>().GetAllAsync(x => !x.IsDeleted);

            var l = new List<Apartment>();
            l = res.ToList();
            return res;
        }
    }
}
