using Microsoft.EntityFrameworkCore;

namespace BankTransactions.Models
{
    public class TransactionDbContext:DbContext
    {
        // Dependency injection
        public TransactionDbContext(DbContextOptions<TransactionDbContext> options) : base(options)
        {   
        }

        // Map the transaction model to the physical database
        // Create Table TRANSACTIONS
        public DbSet<Transaction> Transactions { get; set; }
    }
}
