using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models.Entities
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string EmergencyContact { get; set; }

        [NotMapped]
        public int Age
        {
            get
            {
                if (DateOfBirth == null) return 0;
                var today = DateTime.Today;
                var age = today.Year - DateOfBirth.Year;
                if (DateOfBirth.Date > today.AddYears(-age)) age--;
                return age;
            }
        }

        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<CurrentIllness> CurrentIllnesses { get; set;}
        public virtual ICollection<Insurance> Insurances { get; set;}
        public virtual ICollection<MedicalHistory> MedicalHistories { get; set; }
        public virtual ICollection<PatientTest> PatientTests { get; set; }
    }
}
