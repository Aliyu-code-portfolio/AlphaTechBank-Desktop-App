using AlphaTechBank.Model.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Column(TypeName ="money")]
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public bool IsDeleted { get; set; }
    }
}
