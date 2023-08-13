using Project.Models;
using Project.Models.Entities;
using Project.Repositories;
using Project.Repositories.Interfaces;
using Project.Services.Interfaces;

namespace Project.Services
{
    public class CurrentIllnessService : ICurrentIllnessService
    {
        private readonly IRepository<CurrentIllness> _currentIllnessRepository;

        public CurrentIllnessService(IRepository<CurrentIllness> currentIllnessRepository)
        {
            _currentIllnessRepository = currentIllnessRepository;
        }

        public async Task AddCurrentIllness(CurrentIllness currentIllness)
        {
            await _currentIllnessRepository.AddAsync(currentIllness);
        }

        public async Task DeleteCurrentIllness(int id)
        {
            await _currentIllnessRepository.DeleteAsync(id);
        }

        public async Task<IQueryable<CurrentIllness>> GetAllCurrentIllnesses()
        {
            throw new NotImplementedException();
        }

        public Task<CurrentIllness> GetCurrentIllness(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateCurrentIllness(CurrentIllness currentIllness)
        {
            await _currentIllnessRepository.UpdateAsync(currentIllness);
        }
    }
}
