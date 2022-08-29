using BankApp.Core.DataAccess;
using BankApp.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BankApp.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountsController : ControllerBase
    {

        private readonly IAccountRepository _accountRepository;

        public AccountsController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        [HttpGet]
        [Route("GetAllAccounts")]
        public IEnumerable<AccountDetails> Get()
        {
            var accounts = _accountRepository.GetAll();
            return accounts.Select(x => new AccountDetails()
            {
                Balance = x.Balance,
                Id = x.Id,
                EmailAddress = x.Email
            });
        }


        //[HttpPost("Account")]
        //public void CreateAccount(string email)
        //{
        //    var user = new Account()
        //    {
        //        Email = email
        //    };
        //    var userId = _accountRepository.CreateUser(user);
        //    _accountRepository.CreateAccount(userId);
        //}


    }


}