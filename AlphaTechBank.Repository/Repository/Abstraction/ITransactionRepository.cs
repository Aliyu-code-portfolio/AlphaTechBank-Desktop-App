using AlphaTechBank.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaTechBank.Repository.Repository.Abstraction
{
    public interface ITransactionRepository:IGenericRepository<Transaction>
    {
        Task<Transaction> GetTransactionById(int id);
        Task<IEnumerable<Transaction>> GetAllDailyTransactions(DateOnly date);
        Task<IEnumerable<Transaction>> GetAllAccountTransaction(string accountNumber);
        Task<IEnumerable<Transaction>> GetAllTransaction();
    }
}
