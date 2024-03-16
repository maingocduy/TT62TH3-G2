using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Web.Http.ModelBinding;
using WebApplication3.Controllers.Data;
using WebApplication3.Entities;


namespace WebApplication3.Service.SponsorService
{
    public class SponsorService : ISponsorService
    {
        private readonly AppDbContext _db;
        public SponsorService(AppDbContext db)
        {
            _db = db;
        }


        public List<sponsor> DeleteSponsor(int id)
        {
            var spon = _db.sponsor.Find(id);
            if (spon == null)
            {
                return null;
            }
            _db.sponsor.Remove(spon);
            _db.SaveChanges();
            return GetAllSponsor();
        }

        public List<sponsor> GetAllSponsor()
        {
            return _db.sponsor.ToList();
        }

        public sponsor GetSponsor(int id)
        {
            var spon = _db.sponsor.FirstOrDefault(x => x.Id_sponsor == id);
            if (spon == null)
            {
                return null;
            }
            return spon;
        }

        public async Task<string> UpdateSponsors(int id, sponsor sponsor)
        {
            try
            {
                var spon = await _db.sponsor.FirstOrDefaultAsync(s => s.Id_sponsor == id);
                if (spon == null)
                {
                    return "Sponsor not found";
                }

                // Kiểm tra định dạng email
                if (!IsValidEmailFormat(sponsor.contact))
                {
                    return "Invalid email format";
                }

                // Cập nhật thông tin người tài trợ
                spon.name = sponsor.name;
                spon.contact = sponsor.contact;
                spon.address = sponsor.address;
                spon.contributionAmount = sponsor.contributionAmount;

                await _db.SaveChangesAsync();

                return "Sponsor updated successfully";
            }
            catch (Exception ex)
            {
                return "An error occurred while updating the sponsor";
            }
        }

        public async Task<string> AddSponsor(sponsor sponsor)
        {
            try
            {
                // Kiểm tra xem email đã tồn tại trong cơ sở dữ liệu hay chưa
                if (_db.sponsor.Any(u => u.contact == sponsor.contact))
                {
                    return "Email already exists in the database";
                }

                // Kiểm tra định dạng email
                if (!IsValidEmailFormat(sponsor.contact))
                {
                    return "Email invalid";
                }

                // Thêm người dùng vào cơ sở dữ liệu
                _db.sponsor.Add(sponsor);
                await _db.SaveChangesAsync();

                return "sponsor added successfully";
            }
            catch (Exception ex)
            {
                return "An error occurred while updating the sponsor";
            }
        }
        private bool IsValidEmailFormat(string email)
        {
            var emailValidation = new EmailAddressAttribute();
            return emailValidation.IsValid(email);
        }

       

       
    }
}
