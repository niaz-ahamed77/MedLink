using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models.Entities
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public DateTime DateAndTime { get; set; }
        public string PurposeOfVisit { get; set; }
    }
}
