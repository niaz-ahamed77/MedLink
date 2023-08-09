using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models.Entities
{
    public class CurrentIllness
    {
        [Key]
        public int IllnessId { get; set; }
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public string DiseaseName { get; set; }
        public DateTime DateDiagnosed { get; set; }
        public string CurrentTreatment { get; set; }
        [ForeignKey("Doctor")]
        public int DoctorId { get; set; }
    }
}
