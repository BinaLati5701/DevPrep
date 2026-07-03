using DevPrep.Api.Models;
using DevPrep.Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DevPrep.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountRepository _repository;

        public AccountsController(IAccountRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<List<Account>> GetAccounts()
        {
            List<Account> accounts = _repository.GetAccounts();

            return Ok(accounts);
        }
    }
}