using Project.Models;
using Project.Models.Entities;
using Project.Repositories;
using Project.Services.Interfaces;

namespace Project.Services
{
    public class AppointmentService : Repository<Appointment>, IAppointmentService
    {
        public AppointmentService(MedLinkDbContext dbContext) : base(dbContext)
        {
        }

        public Task AddAppointment(Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAppointment(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Appointment>> GetAllAppointments()
        {
            throw new NotImplementedException();
        }

        public Task<Appointment> GetAppointment(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAppointment(Appointment appointment)
        {
            throw new NotImplementedException();
        }
    }
}
