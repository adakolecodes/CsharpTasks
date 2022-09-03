using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserRegistrationApp.Data.Scaffolded;
using UserRegistrationApp.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace UserRegistrationApp.Web.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly People _people;

        public UsersController(People people)
        {
            _people = people;
        }

        [HttpGet]
        [Route("GetAllAccounts")]
        public IEnumerable<UserDetails> Get()
        {
            var accounts = _people.GetAllUsers();
            return accounts.Select(x => new UserDetails()
            {
                Id = x.Id,
                Name = x.Name,
                Email = x.Email
            });
        }

        [HttpPost("UserCreate")]
        public int CreateAccount(string name, string email)
        {
            var res = _people.CreateAccount(name, email);
            return res;
        }
    }
}
