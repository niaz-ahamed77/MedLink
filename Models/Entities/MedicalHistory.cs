using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models.Entities
{
    public class MedicalHistory
    {
        [Key]
        public int MedicalHistoryId { get; set; }
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public string DiseaseName { get; set; }
        public DateTime DateDiagnosed { get; set; }
        public string Treatment { get; set; }
    }
}
