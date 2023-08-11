using Project.Models;
using Project.Models.Entities;
using Project.Repositories;
using Project.Repositories.Interfaces;
using Project.Services.Interfaces;

namespace Project.Services
{
    public class MedicalHistoryService : IMedicalHistoryService
    {
        private readonly IRepository<MedicalHistory> _medicalHistoryRepository;

        public MedicalHistoryService(IRepository<MedicalHistory> medicalHistoryRepostiory)
        {
            _medicalHistoryRepository = medicalHistoryRepostiory;
        }

        public async Task AddMedicalHistory(MedicalHistory medicalHistory)
        {
            await _medicalHistoryRepository.AddAsync(medicalHistory);
        }

        public async Task DeleteMedicalHistory(int id)
        {
            await _medicalHistoryRepository.DeleteAsync(id);
        }

        public Task<IQueryable<MedicalHistory>> GetMedicalHistories()
        {
            throw new NotImplementedException();
        }

        public Task<MedicalHistory> GetMedicalHistory(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateMedicalHistory(MedicalHistory medicalHistory)
        {
            await _medicalHistoryRepository.UpdateAsync(medicalHistory);
        }
    }
}
