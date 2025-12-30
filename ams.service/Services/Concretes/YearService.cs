namespace ams.service.Services.Concretes
{
    using ams.data.UnitOfWorks;
    using ams.entity.DTOs;
    using ams.entity.Entities;
    using ams.service.Services.Abstractions;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class YearService : IYearService
    {
        private readonly IUnitOfWork Uow;

        public YearService(IUnitOfWork uow)
        {
            Uow = uow;
        }

        public async Task<List<YearDTO.Combo>> GetComboYears()
        {
            var year = await Uow.GetRepository<Year>().GetAllAsync(x => !x.IsDeleted);

            var years = year.ConvertAll(x => new YearDTO.Combo
            {
                Id = x.Id,
                YearTX = x.YearTX,
            });

            return years;
        }
    }
}
