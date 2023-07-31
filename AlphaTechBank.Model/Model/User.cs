using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaTechBank.Model.Model
{
    public class User:BaseModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public ICollection<Account> Accounts { get; set; }
    }
}
