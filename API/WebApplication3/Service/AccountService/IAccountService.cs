using WebApplication3.Entities;

namespace WebApplication3.Service.AccountService
{
    public interface IAccountService
    {
        List<account> GetAllAcc();
        account GetAccounts(int id);
        List<account> AddAcount(account acc);

        List<account> UpdatePasswordAcc(account acc);
        List<account> DeleteAccount(int id);
    }
}
