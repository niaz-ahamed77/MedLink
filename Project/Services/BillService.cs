using Project.Models;
using Project.Models.Entities;
using Project.Repositories;
using Project.Services.Interfaces;

namespace Project.Services
{
    public class BillService : Repository<Bill>, IBillService
    {
        public BillService(MedLinkDbContext dbContext) : base(dbContext)
        {
        }

        public Task AddBill(Bill bill)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBill(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Bill>> GetAllBills()
        {
            throw new NotImplementedException();
        }

        public Task<Bill> GetBill(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBill(Bill bill)
        {
            throw new NotImplementedException();
        }
    }
}
