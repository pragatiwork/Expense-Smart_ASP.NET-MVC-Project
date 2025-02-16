using Microsoft.EntityFrameworkCore;

namespace ExpenseSmart.Models
{
    public class ExpensesDBContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }
        public ExpensesDBContext(DbContextOptions<ExpensesDBContext> options)
             : base(options)
        {
                
        }
    }
}
