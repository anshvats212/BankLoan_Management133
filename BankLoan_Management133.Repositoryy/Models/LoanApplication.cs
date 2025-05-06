using System.ComponentModel.DataAnnotations;

namespace BankLoan_Management133.Models
{
    public class LoanApplication
    {
        [Key]
        public int ApplicationId { get; set; }
        public int CustomerId { get; set; }
        public int LoanProductId { get; set; }
        public decimal LoanAmount { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string ApprovalStatus { get; set; } // PENDING, APPROVED, REJECTED
    }
}
