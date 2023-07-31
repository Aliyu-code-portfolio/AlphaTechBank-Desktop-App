using AlphaTechBank.Model.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AlphaTechBank.Model.Model
{
    public class Account
    {
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int TransactionPin { get; set; }
        public string PhoneNumber { get; set; }
        public string AccountNumber { get; set; }
        public AccountType AccountType { get; set; }
        public decimal Balance { get; set; }
        public decimal MInBalance { get; set; } //=> AccountType == AccountType.Savings ? 1000 : 0;
        public bool IsActive { get; set; } = true;
        public List<Transaction> Transations { get; set; } //= new List<Transaction>();
        public User User { get; set; }
    }
}
