using AccountService.Enitities;

namespace AccountService.Interfaces
{
    public interface IAccountService
    {
        Task<Account> GetAccount(int id);
        Task<Account> CreateAccount(Account account);
    }
}
