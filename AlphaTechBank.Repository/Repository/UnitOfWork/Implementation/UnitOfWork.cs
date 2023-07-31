using AlphaTechBank.Repository.Data;
using AlphaTechBank.Repository.Repository.Abstraction;
using AlphaTechBank.Repository.Repository.Implementation;
using AlphaTechBank.Repository.Repository.UnitOfWork.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaTechBank.Repository.Repository.UnitOfWork.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataBaseContext _dataBaseContext;
        private IAccountRepository _accountRepository;
        private IUserRepository _userRepository;
        private ITransactionRepository _transactionRepository;
        public UnitOfWork(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }
        public IUserRepository UserRepository => _userRepository?? new UserRepository(_dataBaseContext);

        public IAccountRepository AccountRepository => _accountRepository?? new AccountRepository(_dataBaseContext);    

        public ITransactionRepository TransactionRepository => _transactionRepository?? new TransactionRepository(_dataBaseContext);


        public async Task SaveAsync()
        {
            await _dataBaseContext.SaveChangesAsync();
        }
        public void Dispose()
        {
            _dataBaseContext?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
