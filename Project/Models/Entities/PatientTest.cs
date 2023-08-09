using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models.Entities
{
    public class PatientTest
    {
        [Key]
        public int PatientTestId { get; set; }
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        [ForeignKey("Test")]
        public int TestId { get; set; }
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
        public DateTime DateOfTest { get; set; }
        public string Results { get; set; }
    }
}
