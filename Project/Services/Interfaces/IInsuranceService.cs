using Project.Models.Entities;

namespace Project.Services.Interfaces
{
    public interface IInsuranceService
    {
        Task AddInsurance(Insurance insurance);
        Task<Insurance> GetInsurance(int id);
        Task<IQueryable<Insurance>> GetAllInsurances();
        Task DeleteInsurance(int id);
        Task UpdateInsurance(Insurance insurance);
    }
}
