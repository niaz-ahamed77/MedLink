using Project.Models;
using Project.Models.Entities;
using Project.Repositories;
using Project.Services.Interfaces;

namespace Project.Services
{
    public class DoctorService : Repository<Doctor>, IDoctorService
    {
        public DoctorService(MedLinkDbContext dbContext) : base(dbContext)
        {
        }

        public Task AddDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public Task DeleteDoctor(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Patient>> GetAllDoctors()
        {
            throw new NotImplementedException();
        }

        public Task<Doctor> GetDoctor(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateDoctor(Doctor doctor)
        {
            throw new NotImplementedException();
        }
    }
}
