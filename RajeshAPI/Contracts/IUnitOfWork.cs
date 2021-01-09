using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RajeshAPI.Contracts
{
    public interface IUnitOfWork
    {
        Task Save();
    }
}
