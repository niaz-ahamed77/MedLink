using Project.Models;
using Project.Models.Entities;
using Project.Repositories;
using Project.Repositories.Interfaces;
using Project.Services.Interfaces;

namespace Project.Services
{
    public class InsuranceService : IInsuranceService
    {
        private readonly IRepository<Insurance> _insuranceRepository;

        public InsuranceService(IRepository<Insurance> insuranceRepository)
        {
            _insuranceRepository = insuranceRepository;
        }

        public async Task AddInsurance(Insurance insurance)
        {
            await _insuranceRepository.AddAsync(insurance);
        }

        public async Task DeleteInsurance(int id)
        {
            await _insuranceRepository.DeleteAsync(id);
        }

        public async Task<IQueryable<Insurance>> GetAllInsurances()
        {
            throw new NotImplementedException();
        }

        public Task<Insurance> GetInsurance(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateInsurance(Insurance insurance)
        {
            await _insuranceRepository.UpdateAsync(insurance);
        }
    }
}
