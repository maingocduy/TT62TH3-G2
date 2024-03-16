using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Controllers.Data;
using WebApplication3.Entities;
using WebApplication3.Service.AccountService;

namespace WebApplication3.Controllers
{[Route ("api/[controller]")]
        [ApiController]

    public class AccountController : Controller
    {
        private readonly IAccountService accountService ;
        public AccountController (IAccountService accountService)
        {
            this.accountService = accountService ;
        }
        [HttpGet]
        public async Task<ActionResult<List<account>>> GetAllAcc()
        {
            var acc = accountService.GetAllAcc();
            return Ok(acc);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<account>> GetAccount(int id) {
            var accou =  accountService.GetAccounts(id);
            if(accou == null)
            {
                return NotFound("Account not found");
            }
            return Ok (accou);
        }
        [HttpPost]
        public async Task<ActionResult<List<account>>> AddAcount(account acc)
        {
            var accou = accountService.AddAcount(acc);
            // Kiểm tra xem người dùng đã tồn tại hay chưa
            if (accou == null)
            {
                return NotFound("accont already in db");
            }
            return Ok(accou);
        }
        [HttpDelete]
        public async Task<ActionResult<List<account>>> DeleteAccount(int id)
        {
            var accou = accountService.DeleteAccount(id);
            if (accou == null)
            {
                return NotFound("Account not found");
            }
            return Ok(accou);
        }
        [HttpPut]
        public async Task<ActionResult<List<account>>> UpdatePasswordAcc(int id,account acc)
        {
            var account = accountService.UpdatePasswordAcc(acc);
            if (acc == null)
            {
                return NotFound("Account not found");
            }
           return Ok(account);
        }
    }
}
