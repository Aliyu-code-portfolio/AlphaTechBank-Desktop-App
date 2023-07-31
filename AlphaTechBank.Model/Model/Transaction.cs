using AlphaTechBank.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaTechBank.Model.Model
{
    public class Transaction:BaseModel
    {
        public string AccountNumber { get; set; }
        public string ReceiverAccountNumber { get; set; }
        public string ReceiverName { get; set; }
        public TransactionType TransactionType { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
    }
}
