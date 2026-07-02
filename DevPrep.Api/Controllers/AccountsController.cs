using DevPrep.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevPrep.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Account>> GetAccounts()
        {
            List<Account> accounts = new()
            {
                new Account
                {
                    Id = 1,
                    AccountNumber = "100001",
                    AccountType = "Checking",
                    Balance = 1250.75m,
                    IsActive = true
                }
            };

            return Ok(accounts);
        }
    }
}