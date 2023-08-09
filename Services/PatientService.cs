using Project.Models;
using Project.Models.Entities;
using Project.Repositories;
using Project.Services.Interfaces;

namespace Project.Services
{
    public class PatientService : Repository<Patient>, IPatientService
    {
        public PatientService(MedLinkDbContext dbContext) : base(dbContext)
        {
        }

        public Task AddPatient(Patient patient)
        {
            throw new NotImplementedException();
        }

        public Task DeletePatient(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Patient>> GetAllPatients()
        {
            throw new NotImplementedException();
        }

        public Task<Patient> GetPatient(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePatient(Patient patient)
        {
            throw new NotImplementedException();
        }
    }
}
