using Project.Models;
using Project.Models.Entities;
using Project.Repositories;
using Project.Repositories.Interfaces;
using Project.Services.Interfaces;

namespace Project.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IRepository<Appointment> _appointmentRepository;

        public AppointmentService(IRepository<Appointment> appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        public async Task AddAppointment(Appointment appointment)
        {
            await _appointmentRepository.AddAsync(appointment);
        }

        public async Task DeleteAppointment(int id)
        {
            await _appointmentRepository.DeleteAsync(id);
        }

        public async Task<IQueryable<Appointment>> GetAllAppointments()
        {
            return await _appointmentRepository.GetAll();
        }

        public Task<Appointment> GetAppointment(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAppointment(Appointment appointment)
        {
            await _appointmentRepository.UpdateAsync(appointment);
        }
    }
}
