using DevPrep.Api.Data;
using DevPrep.Api.Models;

namespace DevPrep.Api.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ApplicationDbContext _context;

        public AccountRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Account> GetAccounts()
        {
            return _context.Accounts.ToList();
        }
    }
}