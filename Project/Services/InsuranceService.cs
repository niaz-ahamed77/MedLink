using Project.Models;
using Project.Models.Entities;
using Project.Repositories;
using Project.Services.Interfaces;

namespace Project.Services
{
    public class InsuranceService : Repository<InsuranceService>, IInsuranceService
    {
        public InsuranceService(MedLinkDbContext dbContext) : base(dbContext)
        {
        }

        public Task AddInsurance(Insurance insurance)
        {
            throw new NotImplementedException();
        }

        public Task DeleteInsurance(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Insurance>> GetAllInsurance()
        {
            throw new NotImplementedException();
        }

        public Task<Insurance> GetCurrentIllness(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateInsurance(Insurance insurance)
        {
            throw new NotImplementedException();
        }
    }
}
