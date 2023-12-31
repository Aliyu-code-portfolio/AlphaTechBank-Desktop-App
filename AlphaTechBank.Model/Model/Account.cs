﻿using AlphaTechBank.Model.Enum;
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
    public class Account:BaseModel
    {
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int TransactionPin { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public string AccountNumber { get; set; } = string.Empty;
        public AccountType AccountType { get; set; }
        [Column(TypeName = "money")]
        public decimal Balance { get; set; }
        [Column(TypeName = "money")]
        public decimal MInBalance { get; set; } 
        public bool IsActive { get; set; } = true;
        public List<Transaction> Transactions { get; set; }
        public User User { get; set; }

    }
}
