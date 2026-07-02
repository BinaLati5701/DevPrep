using DevPrep.Api.Controllers;
using DevPrep.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Xunit;

namespace DevPrep.Tests
{
    public class AccountsControllerTests
    {
        [Fact]
        public void GetAccounts_ReturnsOkResult_WithAccounts()
        {
            AccountsController controller = new();

            ActionResult<List<Account>> result = controller.GetAccounts();

            OkObjectResult okResult = Assert.IsType<OkObjectResult>(result.Result);
            List<Account> accounts = Assert.IsType<List<Account>>(okResult.Value);

            Assert.Single(accounts);
            Assert.Equal("100001", accounts[0].AccountNumber);
            Assert.Equal("Checking", accounts[0].AccountType);
            Assert.Equal(1250.75m, accounts[0].Balance);
            Assert.True(accounts[0].IsActive);
        }
    }
}