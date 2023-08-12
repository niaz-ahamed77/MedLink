using Project.Models;
using Project.Models.Entities;
using Project.Repositories;
using Project.Repositories.Interfaces;
using Project.Services.Interfaces;

namespace Project.Services
{
    public class BillService : IBillService
    {
        private readonly IRepository<Bill> _billRepository;

        public BillService(IRepository<Bill> billRepository)
        {
            _billRepository = billRepository;
        }

        public async Task AddBill(Bill bill)
        {
            await _billRepository.AddAsync(bill);
        }

        public async Task DeleteBill(int id)
        {
            await _billRepository.DeleteAsync(id);
        }

        public Task<IQueryable<Bill>> GetAllBills()
        {
            throw new NotImplementedException();
        }

        public Task<Bill> GetBill(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateBill(Bill bill)
        {
            await _billRepository.UpdateAsync(bill);
        }
    }
}
