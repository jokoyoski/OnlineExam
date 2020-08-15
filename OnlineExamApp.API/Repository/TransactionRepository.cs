

using System.Transactions;
using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly DataContext _dbContext;

        public TransactionRepository(DataContext dbContext)
        {
            this._dbContext = dbContext;
        }

    }
}