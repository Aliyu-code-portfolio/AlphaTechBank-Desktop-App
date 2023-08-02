using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaTechBank.Model.Model
{
    public class User:BaseModel
    {
        public string Email { get; set; } = string.Empty;
        public bool IsDeleted { get; set; }
        public byte[] Password { get; set; }
        public byte[] PasswordSalt { get; set; }
        public ICollection<Account> Accounts { get; set; }
    }
}
