using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using WebApplication3.Controllers.Data;
using WebApplication3.Entities;
using WebApplication3.Service.AccountService;
using WebApplication3.Service.SponsorService;

namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SponsorController : Controller
    {
        private readonly ISponsorService sponsorService;
        public SponsorController(ISponsorService sponsorService)
        {
            this.sponsorService = sponsorService;
        }
        [HttpGet]
        public async Task<ActionResult<List<sponsor>>> GetAllSponsor()
        {
            var spon = sponsorService.GetAllSponsor();
            return Ok(spon);
        }
        [HttpPost]
        public async Task<ActionResult<string>> AddSponsor(sponsor spon)
        {
            // Kiểm tra xem người dùng đã tồn tại hay chưa
            var result = await sponsorService.AddSponsor(spon);
            if (result == "Sponsor not found")
            {
                return NotFound("Sponsor not found");
            }
            else if (result == "Email invalid")
            {
                return BadRequest("Invalid email format");
            }
            else if (result == "Email already exists in the database")
            {
                return BadRequest("Email already exists in the database");
            }
            else if (result == "Sponsor added successfully")
            {
                return Ok("Sponsor added successfully");
            }
            else
            {
                return StatusCode(500, "An error occurred while updating the sponsor");
            }
        }
        
        [HttpDelete]
        public async Task<ActionResult<List<sponsor>>> DeleteSponsor(int id)
        {
            var spon = sponsorService.DeleteSponsor(id);
            if (spon == null)
            {
                return NotFound("Account not found");
            }
            return Ok(spon);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<sponsor>> GetSponsor(int id)
        {
            var spon = sponsorService.GetSponsor(id);
            if (spon == null)
            {
                return NotFound("Account not found");
            }
            return Ok(spon);
        }
        [HttpPut]
        
            public async Task<ActionResult<string>> UpdateSponsor(int id, sponsor sponsor)
            {
                var result = await sponsorService.UpdateSponsors(id, sponsor);
                if (result == "Sponsor not found")
                {
                    return NotFound("Sponsor not found");
                }
                else if (result == "Invalid email format")
                {
                    return BadRequest("Invalid email format");
                }
                else if (result == "Sponsor updated successfully")
                {
                    return Ok("Sponsor updated successfully");
                }
                else
                {
                    return StatusCode(500, "An error occurred while updating the sponsor");
                }
            }
        
    }
}
