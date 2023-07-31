using AlphaTechBank.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaTechBank.Repository.Repository.Abstraction
{
    public interface IAccountRepository
    {
        Task<Account> GetAccountById(int id);
        Task<Account> GetAccountByAccountNumber(string accountNumber);
        Task<IEnumerable<Account>> GetAccountUsers();
    }
}
