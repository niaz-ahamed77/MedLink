using Project.Models.Entities;

namespace Project.Services.Interfaces
{
    public interface IInsuranceService
    {
        Task AddInsurance(Insurance insurance);
        Task<Insurance> GetCurrentIllness(int id);
        Task<IQueryable<Insurance>> GetAllInsurance();
        Task DeleteInsurance(int id);
        Task UpdateInsurance(Insurance insurance);
    }
}
