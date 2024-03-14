using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Controllers.Data;
using WebApplication3.Entities;

namespace WebApplication3.Controllers
{[Route ("api/[controller]")]
        [ApiController]

    public class AccountController : Controller
    {
        private readonly AppDbContext _db;
        public AccountController (AppDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public IActionResult GetAllAcc()
        {
            var acc = _db.account.ToList();
            return Ok(acc);
        }
        [HttpGet("{id}")]
        public IActionResult GetAccount(int id) {
            var accou = _db.account.Find(id);
            if(accou == null)
            {
                return NotFound("Account not found");
            }
            return Ok (accou);
        }
        [HttpPost]
        public IActionResult AddAcount(account acc)
        {
            // Kiểm tra xem người dùng đã tồn tại hay chưa
            if (_db.account.Any(u => u.Username == acc.Username))
            {
                return BadRequest("Username is already taken");
            }

            // Tạo đối tượng User từ dữ liệu đầu vào
            var newAcc = new account
            {
                Username = acc.Username,
                Password = acc.Password // Bạn nên mã hóa mật khẩu trước khi lưu vào cơ sở dữ liệu
            };

            // Thêm người dùng mới vào cơ sở dữ liệu
            _db.account.Add(newAcc);
            _db.SaveChanges();

            return Ok("Registration successful");
        }
        [HttpDelete]
        public IActionResult DeleteAccount(int id)
        {
            var acc = _db.account.Find(id);
            if (acc == null)
            {
                return NotFound("Account not found");
            }
            _db.account.Remove(acc);
            _db.SaveChanges();
            return Ok(_db.account.ToList());
        }
        [HttpPut]
        public IActionResult UpdatePasswordAcc(account acc)
        {
            var account = _db.account.Find(acc.Id_account);
            if (acc == null)
                {
                    return NotFound("Account not found");
                }
            account.Password = acc.Password;
            _db.SaveChanges();
            return Ok(_db.account.ToList());
        }
    }
}
