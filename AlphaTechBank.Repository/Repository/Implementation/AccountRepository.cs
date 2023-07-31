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
    public class AccountRepository : IAccountRepository
    {
        private readonly DbSet<Account> _accounts;

        public AccountRepository(DataBaseContext databaseContext)
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
    }
}
