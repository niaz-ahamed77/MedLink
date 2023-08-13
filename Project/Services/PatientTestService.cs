using Project.Models;
using Project.Models.Entities;
using Project.Repositories;
using Project.Repositories.Interfaces;
using Project.Services.Interfaces;

namespace Project.Services
{
    public class PatientTestService : IPatientTestService
    {
        private readonly IRepository<PatientTest> _patientTestRepository;

        public PatientTestService(IRepository<PatientTest> patientTestRepository)
        {
            _patientTestRepository = patientTestRepository;
        }

        public async Task AddPatientTest(PatientTest patientTest)
        {
            await _patientTestRepository.AddAsync(patientTest);
        }

        public async Task DeletePatientTest(int id)
        {
            await _patientTestRepository.DeleteAsync(id);
        }

        public async Task<IQueryable<PatientTest>> GetAllPatientTests()
        {
            throw new NotImplementedException();
        }

        public Task<PatientTest> GetPatientTest(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdatePatientTest(PatientTest patientTest)
        {
            await _patientTestRepository.UpdateAsync(patientTest);
        }
    }
}
