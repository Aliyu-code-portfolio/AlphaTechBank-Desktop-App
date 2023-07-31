using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphaTechBank.Repository.Repository.Abstraction
{
    public interface IGenericRepository
    {
        Task CreateAsync();
        void Update();
        void Remove();
        void RemoveRange();
    }
}
