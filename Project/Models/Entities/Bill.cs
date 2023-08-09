using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models.Entities
{
    public class Bill
    {
        [Key]
        public int BillId { get; set; }
        [ForeignKey("Patient")]
        public int PatientId { get; set; }
        public DateTime Date { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentStatus { get; set; }
        public string BillingAddress { get; set; }
    }
}
