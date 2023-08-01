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
        }

        public Task<IEnumerable<Transaction>> GetAllDailyTransaction(string date)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Transaction>> GetAllTransactionByAccountNumber(string accountNumber)
        {
            throw new NotImplementedException();
        }
    }
}
