using Microsoft.EntityFrameworkCore;
using System.Security.Principal;
using WebApplication3.Controllers.Data;
using WebApplication3.Entities;

namespace WebApplication3.Service.AccountService
{
    public class AccountService : IAccountService
    {
        private readonly AppDbContext _db;
        public AccountService(AppDbContext db)
        {
            _db = db;
        }

        public List<account> AddAcount(account acc)
        {
            if (_db.account.Any(u => u.Username == acc.Username))
            {
                return null;
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

            return GetAllAcc();
        }

        public List<account> DeleteAccount(int id)
        {
            var acc = _db.account.Find(id);
            if (acc == null)
            {
                return null;
            }
            _db.account.Remove(acc);
            _db.SaveChanges();
            return GetAllAcc();
        }

        public account GetAccounts(int id)
        {
            var accou = _db.account.FirstOrDefault(x => x.Id_account == id);
            if (accou == null)
            {
                return null;
            }
            return accou;

        }

        public List<account> GetAllAcc()
        {
            return _db.account.ToList();
        }

        public List<account> UpdatePasswordAcc(account acc)
        {
            var account = _db.account.Find(acc.Id_account);
            if (acc == null)
            {
                return null;
            }
            account.Password = acc.Password;
            _db.SaveChanges();
            return GetAllAcc();
        }
    }
}
