using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models.Entities
{
    public class Insurance
    {
        [Key]
        public int InsuranceId { get; set; }
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public string Providername { get; set; }
        public string PolicyNumber { get; set; }
        public string CoverageDetails { get; set; }
    }
}
