using AlphaTechBank.Model.Model;

namespace AlphaTechBank.Core.Services.Abstraction
{
    public interface ITransactionService
    {
        Task<IEnumerable<Transaction>> GetAllTransactionByAccountNumber(string accountNumber);
        Task<IEnumerable<Transaction>> GetAllDailyTransaction(string date);
        Task DeleteTransactionById(int id);
    }
}
