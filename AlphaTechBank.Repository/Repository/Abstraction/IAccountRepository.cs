using AlphaTechBank.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaTechBank.Repository.Repository.Abstraction
{
    public interface IAccountRepository:IGenericRepository<Account>
    {
        Task<Account> GetAccountById(int id);
        Task<Account> GetAccountByAccountNumber(string accountNumber);
        Task<IEnumerable<Account>> GetAccountUsers();
        Task<IEnumerable<Account>> GetAllUserAccounts(int userId);
        Task<string> ValidateAccount(string accountNumber);
    }
}
