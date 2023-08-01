using AlphaTechBank.Model.Model;
using AlphaTechBank.Repository.Data;
using AlphaTechBank.Repository.Repository.Abstraction;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaTechBank.Repository.Repository.Implementation
{
    public class AccountRepository :GenericRepository<Account>, IAccountRepository
    {
        private readonly DbSet<Account> _accounts;

        public AccountRepository(DataBaseContext databaseContext):base(databaseContext)
        {
            _accounts = databaseContext.Set<Account>();
        }
        public async Task<Account> GetAccountByAccountNumber(string accountNumber)
        {
            return await _accounts.Where(a => a.AccountNumber == accountNumber && a.IsActive)
                .Include(a => a.Transactions).FirstOrDefaultAsync();
        }

        public async Task<Account> GetAccountById(int id)
        {
            return await _accounts.Where(a => a.Id == id && a.IsActive)
               .Include(a => a.Transactions).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Account>> GetAccountUsers()
        {
            return await _accounts.Where(a =>a.IsActive)
               .Include(a => a.Transactions).ToListAsync();
        }

        public async Task<IEnumerable<Account>> GetAllUserAccounts(int userId)
        {
            return await _accounts.Where(a => a.IsActive && a.UserId==userId)
               .Include(a => a.Transactions).ToListAsync();
        }

        public async Task<string> ValidateAccount(string accountNumber)
        {
            return await _accounts.Where(a =>a.AccountNumber==accountNumber && a.IsActive).Select(a=>a.FirstName+" "+a.LastName)
               .FirstOrDefaultAsync();
        }
    }
}
