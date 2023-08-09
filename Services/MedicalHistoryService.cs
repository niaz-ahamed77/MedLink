using Project.Models;
using Project.Models.Entities;
using Project.Repositories;
using Project.Services.Interfaces;

namespace Project.Services
{
    public class MedicalHistoryService : Repository<MedicalHistory>, IMedicalHistoryService
    {
        public MedicalHistoryService(MedLinkDbContext dbContext) : base(dbContext)
        {
        }

        public Task AddMedicalHistory(MedicalHistory insurance)
        {
            throw new NotImplementedException();
        }

        public Task DeleteMedicalHistory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<MedicalHistory>> GetMedicalHistories()
        {
            throw new NotImplementedException();
        }

        public Task<MedicalHistory> GetMedicalHistory(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateMedicalHistory(MedicalHistory medicalHistory)
        {
            throw new NotImplementedException();
        }
    }
}
