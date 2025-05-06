using System.ComponentModel.DataAnnotations;
namespace BankLoan_Management133.Models
{
    public class LoanProduct
    {
        [Key]
        public int LoanProductId { get; set; }
        public string ProductName { get; set; }
        public decimal InterestRate { get; set; }
        public decimal MinAmount { get; set; }
        public decimal MaxAmount { get; set; }
        public int Tenure { get; set; } // Months
    }
}
