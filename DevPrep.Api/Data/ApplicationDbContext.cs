using DevPrep.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace DevPrep.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; } = null!;
    }
}