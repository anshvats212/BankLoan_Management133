using System.ComponentModel.DataAnnotations;

namespace BankLoan_Management133.Models
{
    public class CustomerEntity
    {
        [Key]
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string KycStatus { get; set; }

    }
}
