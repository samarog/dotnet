using Microsoft.EntityFrameworkCore;

namespace SmartGast.Data
{
    public class SmartGastDbContext : DbContext
    {
        public DbSet<SmartGast.Models.Expense> ExpensesTable { get; set; }

        public SmartGastDbContext(DbContextOptions<SmartGastDbContext> options) : base(options)
        {
            
        }
    }
}
