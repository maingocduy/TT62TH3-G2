using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using WebApplication3.Controllers.Data;
using WebApplication3.Entities;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SponsorController : Controller
    {
        private readonly AppDbContext _db;
        public SponsorController(AppDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public ActionResult GetSponsor()
        {
            var spon = _db.sponsor.ToList();
            return Ok(spon);
        }
        [HttpPost]
        public IActionResult AddSponsor(sponsor spon)
        {
            // Kiểm tra xem người dùng đã tồn tại hay chưa
            try
            {
                // Process sponsorship registration
                var emailValidation = new EmailAddressAttribute();
            

                if (_db.sponsor.Any(u => u.contact == spon.contact))
                {
                    return BadRequest("your email already in db");
                }
                if (!emailValidation.IsValid(spon.contact))
                {
                    ModelState.AddModelError("Email", "Invalid email format");
                    return BadRequest(ModelState);
                }
                else
                {
                    // Trường hợp xử lý thất bại vì một lý do nào đó
                    return Ok("Sponsorship registered successfully");
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ bất kỳ nếu có
                return StatusCode(500, "pls enter ur infor");
            }
        }
        private bool IsValidEmail(string email)
        { 
                var address = new System.Net.Mail.MailAddress(email);
                return address.Address == email;
        }
        private bool ProcessSponsorshipRegistration(sponsor sponsorship)
        {
            // Đây là nơi triển khai logic xử lý đăng ký tài trợ

            // Ví dụ: Kiểm tra xem tài trợ có hợp lệ không
            if (IsSponsorshipValid(sponsorship))
            {
                // Nếu tất cả điều kiện hợp lệ, có thể thực hiện việc lưu trữ tài trợ vào cơ sở dữ liệu hoặc hệ thống khác
                // Ở đây, chúng ta chỉ giả định rằng việc xử lý thành công nếu dữ liệu tài trợ là hợp lệ
                // Trong ứng dụng thực tế, bạn sẽ có thể thực hiện các thao tác lưu trữ, gửi email xác nhận, vv...
                return true;
            }
            else
            {
                // Trường hợp dữ liệu tài trợ không hợp lệ, trả về false
                return false;
            }
        }
        private bool IsSponsorshipValid(sponsor sponsorship)
        {
            // Kiểm tra tính hợp lệ của dữ liệu tài trợ ở đây
            // Đây chỉ là một ví dụ, trong thực tế bạn cần thêm các kiểm tra phù hợp với yêu cầu của ứng dụng

            // Ví dụ: Kiểm tra xem các trường bắt buộc có được điền đầy đủ không
            if (string.IsNullOrEmpty(sponsorship.name) || string.IsNullOrEmpty(sponsorship.contact))
            {
                return false;
            }
            else if (_db.sponsor.Any(u => u.contact == sponsorship.contact))
            {
                return false;
            }

            // Kiểm tra các điều kiện khác nếu cần

            // Nếu tất cả điều kiện hợp lệ, trả về true
            return true;
        }
        [HttpDelete]
        public IActionResult DeleteAccount(int id)
        {
            var spon = _db.sponsor.Find(id);
            if (spon == null)
            {
                return NotFound("Account not found");
            }
            _db.sponsor.Remove(spon);
            _db.SaveChanges();
            return Ok(_db.sponsor.ToList());
        }
    }
}
