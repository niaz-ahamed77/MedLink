using System.ComponentModel.DataAnnotations;

namespace Project.Models.Entities
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public string ContactNumber { get; set; }

        public ICollection<CurrentIllness> CurrentIllnesses { get; set; }
        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<PatientTest> PatientTests { get; set; }
    }
}
