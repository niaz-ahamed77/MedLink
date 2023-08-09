using Project.Models.Entities;

namespace Project.Services.Interfaces
{
    public interface IAppointmentService
    {
        Task AddAppointment(Appointment appointment);
        Task<Appointment> GetAppointment(int id);
        Task<IQueryable<Appointment>> GetAllAppointments();
        Task DeleteAppointment(int id);
        Task UpdateAppointment(Appointment appointment);
    }
}
