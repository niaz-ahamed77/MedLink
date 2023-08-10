using Project.Models.Entities;

namespace Project.Services.Interfaces
{
    public interface IPatientService
    {
        Task AddPatient(Patient patient);
        Task<Patient> GetPatient(int id);
        Task<IQueryable<Patient>> GetAllPatients();
        Task DeletePatient(int id);
        Task UpdatePatient(Patient patient);
    }
}
 