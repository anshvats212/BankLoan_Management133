using System.ComponentModel.DataAnnotations;

namespace BankLoan_Management133.Models
{
    public class Repayment
    {
        [Key]
        public int RepaymentId { get; set; }
        public int ApplicationId { get; set; }
        public DateTime DueDate { get; set; }
        public decimal AmountDue { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentStatus { get; set; } // PENDING, COMPLETED
    }
}
