﻿using Project.Models.Entities;

namespace Project.Services.Interfaces
{
    public interface IDoctorService
    {
        Task AddDoctor(Doctor doctor);
        Task<Doctor> GetDoctor(int id);
        Task<IQueryable<Patient>> GetAllDoctors();
        Task DeleteDoctor(int id);
        Task UpdateDoctor(Doctor doctor);
    }
}
