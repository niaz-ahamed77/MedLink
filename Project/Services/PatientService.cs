using Project.Models;
using Project.Models.Entities;
using Project.Repositories;
using Project.Repositories.Interfaces;
using Project.Services.Interfaces;

namespace Project.Services
{
    public class PatientService : IPatientService
    {
        private readonly IRepository<Patient> _patientRepository;

        public PatientService(IRepository<Patient> patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public async Task AddPatient(Patient patient)
        {
            await _patientRepository.AddAsync(patient);
        }

        public async Task DeletePatient(int id)
        {
            await _patientRepository.DeleteAsync(id);
        }

        public async Task<IQueryable<Patient>> GetAllPatients()
        {
            return await _patientRepository.GetAll(p => p.Bills, p => p.MedicalHistories, p => p.Insurances);
        }

        public Task<Patient> GetPatient(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdatePatient(Patient patient)
        {
            await _patientRepository.UpdateAsync(patient);
        }
    }
}
