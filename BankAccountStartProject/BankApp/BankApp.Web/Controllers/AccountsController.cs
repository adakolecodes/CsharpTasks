using BankApp.Core.DataAccess;
using BankApp.Core.Features;
using BankApp.Data.Scaffolded;
using BankApp.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BankApp.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountsController : ControllerBase
    {

        private readonly IAccountRepository _accountRepository;
        private readonly PayInMoney _payInMoney;
        private readonly WithdrawMoney _withdraw;
        private readonly TransferMoney _transfer;

        public AccountsController(IAccountRepository accountRepository, PayInMoney payInMoney, WithdrawMoney withdraw, TransferMoney transfer)
        {
            _accountRepository = accountRepository;
            _payInMoney = payInMoney;
            _withdraw = withdraw;
            _transfer = transfer;
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

        [HttpPost("AccountCreate")]
        public int CreateAccount(string email)
        {
            var account = new AccountDb()
            {
                Email = email
            };
            
            _accountRepository.CreateAccount(account.Email);

            return account.Id;
        }

        [HttpGet("PayIn")]
        public void PayIn(int accountId, decimal amount)
        {
            _payInMoney.Execute(accountId, amount);
        }

        [HttpGet("Withdrawal")]
        public void withdrawal(int accountId, decimal amount)
        {
            _withdraw.Execute(accountId, amount);
        }

        [HttpGet("Transfer")]
        public void withdrawal(int fromAccount, int toAccount, decimal amount)
        {
            _transfer.Execute(fromAccount, toAccount, amount);
        }

    }


}