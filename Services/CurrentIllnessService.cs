using Project.Models;
using Project.Models.Entities;
using Project.Repositories;
using Project.Services.Interfaces;

namespace Project.Services
{
    public class CurrentIllnessService : Repository<CurrentIllness>, ICurrentIllnessService
    {
        public CurrentIllnessService(MedLinkDbContext dbContext) : base(dbContext)
        {
        }

        public Task AddCurrentIllness(CurrentIllness currentIllness)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCurrentIllness(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<CurrentIllness>> GetAllCurrentIllnesses()
        {
            throw new NotImplementedException();
        }

        public Task<CurrentIllness> GetCurrentIllness(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCurrentIllness(CurrentIllness currentIllness)
        {
            throw new NotImplementedException();
        }
    }
}
