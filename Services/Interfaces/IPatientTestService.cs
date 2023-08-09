using Project.Models.Entities;

namespace Project.Services.Interfaces
{
    public interface IPatientTestService
    {
        Task AddPatientTest(PatientTest patientTest);
        Task<PatientTest> GetPatientTest(int id);
        Task<IQueryable<PatientTest>> GetAllPatientTests();
        Task DeletePatientTest(int id);
        Task UpdatePatientTest(PatientTest patientTest);
    }
}
