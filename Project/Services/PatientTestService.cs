using Project.Models;
using Project.Models.Entities;
using Project.Repositories;
using Project.Services.Interfaces;

namespace Project.Services
{
    public class PatientTestService : Repository<PatientTest>, IPatientTestService
    {
        public PatientTestService(MedLinkDbContext dbContext) : base(dbContext)
        {
        }

        public Task AddPatientTest(PatientTest patientTest)
        {
            throw new NotImplementedException();
        }

        public Task DeletePatientTest(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<PatientTest>> GetAllPatientTests()
        {
            throw new NotImplementedException();
        }

        public Task<PatientTest> GetPatientTest(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePatientTest(PatientTest patientTest)
        {
            throw new NotImplementedException();
        }
    }
}
