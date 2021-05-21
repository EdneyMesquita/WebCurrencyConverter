using Microsoft.EntityFrameworkCore;
using WebCurrencyConverter.Models;

namespace WebCurrencyConverter.Repositories.Contexts
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Currency> Currencies { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            
        }
    }
}