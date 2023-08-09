using Project.Models.Entities;

namespace Project.Services.Interfaces
{
    public interface ICurrentIllnessService
    {
        Task AddCurrentIllness(CurrentIllness currentIllness);
        Task<CurrentIllness> GetCurrentIllness(int id);
        Task<IQueryable<CurrentIllness>> GetAllCurrentIllnesses();
        Task DeleteCurrentIllness(int id);
        Task UpdateCurrentIllness(CurrentIllness currentIllness);
    }
}
