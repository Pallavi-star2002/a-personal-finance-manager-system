
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace ProjectFinancePortal.Models
{
    public class FinanceContext:DbContext
    {
        public DbSet<Transaction> Transactions { get; set; }

        public FinanceContext(DbContextOptions<FinanceContext> options) : base(options) { }
    
}
}
