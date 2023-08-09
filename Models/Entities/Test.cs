using System.ComponentModel.DataAnnotations;

namespace Project.Models.Entities
{
    public class Test
    {
        [Key]
        public int TestId { get; set; }
        public string TestName { get; set; }
        public string TestDetails { get; set; }

        public ICollection<PatientTest> PatientTests { get; set; }
    }
}
