using Microsoft.EntityFrameworkCore;
using Project.Models.Entities;

namespace Project.Models
{
    public class MedLinkDbContext : DbContext
    {
        public MedLinkDbContext(DbContextOptions<MedLinkDbContext> options) : base(options)
        { 

        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<CurrentIllness> CurrentIllnesses { get; set;}
        public DbSet<Bill> Bills { get; set;}
        public DbSet<Insurance> Insurances { get; set;}
        public DbSet<Doctor> Doctors { get; set;}
        public DbSet<PatientTest> PatientTests { get; set;}
        public DbSet<MedicalHistory> MedicalHistories { get; set;}
        public DbSet<Patient> Patients { get; set;}
        public DbSet<Test> Tests { get; set;}
    }
}
