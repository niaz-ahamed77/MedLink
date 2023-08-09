using Project.Models.Entities;

namespace Project.Services.Interfaces
{
    public interface IMedicalHistoryService
    {
        Task AddMedicalHistory(MedicalHistory insurance);
        Task<MedicalHistory> GetMedicalHistory(int id);
        Task<IQueryable<MedicalHistory>> GetMedicalHistories();
        Task DeleteMedicalHistory(int id);
        Task UpdateMedicalHistory(MedicalHistory medicalHistory);
    }
}
