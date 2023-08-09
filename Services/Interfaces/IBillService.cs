using Project.Models.Entities;

namespace Project.Services.Interfaces
{
    public interface IBillService
    {
        Task AddBill(Bill bill);
        Task<Bill> GetBill(int id);
        Task<IQueryable<Bill>> GetAllBills();
        Task DeleteBill(int id);
        Task UpdateBill(Bill bill);
    }
}
