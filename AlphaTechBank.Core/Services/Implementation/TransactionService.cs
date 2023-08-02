using AlphaTechBank.Core.Services.Abstraction;
using AlphaTechBank.Model.Model;
using AlphaTechBank.Repository.Repository.UnitOfWork.Abstraction;

namespace AlphaTechBank.Core.Services.Implementation
{
    public class TransactionService : ITransactionService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TransactionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task DeleteTransactionById(int id)
        {
            Transaction transaction = await _unitOfWork.TransactionRepository
                .GetTransactionById(id);
            _unitOfWork.TransactionRepository.Remove(transaction);
            await _unitOfWork.SaveAsync();
            //_unitOfWork.Dispose();
        }

        public async Task<IEnumerable<Transaction>> GetAllDailyTransactions(string date)
        {
            bool isValidDate = DateOnly.TryParse(date, out DateOnly dateConverted);
            if (!isValidDate)
            {
                return null;
            }
            IEnumerable<Transaction> transactions =await _unitOfWork.TransactionRepository
                .GetAllDailyTransactions(dateConverted);
            return transactions;
        }

        public async Task<IEnumerable<Transaction>> GetAllTransactionByAccountNumber(string accountNumber)
        {
            IEnumerable<Transaction> transactions =await _unitOfWork.TransactionRepository
                .GetAllAccountTransaction(accountNumber);
            return transactions;
        }
    }
}
