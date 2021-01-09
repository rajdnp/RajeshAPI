using RajeshAPI.Contracts;
using RajeshAPI.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RajeshAPI.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext appDbContext;

        public UnitOfWork(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task Save()
        {
            await appDbContext.SaveChangesAsync();
        }
    }
}
