using DevPrep.Api.Models;

namespace DevPrep.Api.Repositories
{
    public interface IAccountRepository
    {
        List<Account> GetAccounts();
    }
}