using Microsoft.EntityFrameworkCore;

namespace BankLoan_Management133.Models
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> contextOptions) : base(contextOptions) { }
 
        public DbSet<CustomerEntity> customerEntities { get; set; }
        public DbSet<LoanApplication> loanApplications { get; set; }
        public DbSet<LoanProduct> loanProducts { get; set; }
        public DbSet<Repayment> repayments { get; set; }
    }
}
