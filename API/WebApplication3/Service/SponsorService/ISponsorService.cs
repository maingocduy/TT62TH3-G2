using Microsoft.AspNetCore.Mvc;
using WebApplication3.Entities;

namespace WebApplication3.Service.SponsorService
{
    public interface ISponsorService
    {
        List<sponsor> GetAllSponsor();
        Task<string> AddSponsor(sponsor sponsor);
        List<sponsor> DeleteSponsor(int id);
        sponsor GetSponsor(int id);
        Task<string> UpdateSponsors(int id ,sponsor sponsor);
    }
}
