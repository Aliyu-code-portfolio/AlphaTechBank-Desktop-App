using AlphaTechBank.Model.Model;
using AlphaTechBank.Repository.Data;
using AlphaTechBank.Repository.Repository.Abstraction;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaTechBank.Repository.Repository.Implementation
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly DbSet<Transaction> _transactions;

        public TransactionRepository(DataBaseContext databaseContext)
        {
            _transactions = databaseContext.Set<Transaction>();
        }
        public async Task<Transaction> GetTransactionById(int id)
        {
            return await _transactions.Where(t => t.Id == id && !t.IsDeleted)
               .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Transaction>> GetAllAccountTransaction(string accountNumber)
        {
            return await _transactions.Where(t => t.AccountNumber == accountNumber && !t.IsDeleted)
               .ToListAsync();
        }

        public async Task<IEnumerable<Transaction>> GetAllTransaction()
        {
            return await _transactions.Where(t => !t.IsDeleted)
               .ToListAsync();
        }
    }
}
