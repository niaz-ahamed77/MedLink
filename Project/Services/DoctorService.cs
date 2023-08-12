using Project.Models;
using Project.Models.Entities;
using Project.Repositories;
using Project.Repositories.Interfaces;
using Project.Services.Interfaces;

namespace Project.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IRepository<Doctor> _doctorRepository;

        public DoctorService(IRepository<Doctor> doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public async Task AddDoctor(Doctor doctor)
        {
            await _doctorRepository.AddAsync(doctor);
        }

        public async Task DeleteDoctor(int id)
        {
            await _doctorRepository.DeleteAsync(id);
        }

        public async Task<IQueryable<Doctor>> GetAllDoctors()
        {
            return await _doctorRepository.GetAll();
        }

        public Task<Doctor> GetDoctor(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateDoctor(Doctor doctor)
        {
            await _doctorRepository.UpdateAsync(doctor);
        }
    }
}
