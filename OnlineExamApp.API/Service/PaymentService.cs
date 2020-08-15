using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Service
{
    public class PaymentService : IPaymentService
    {
        private readonly ITransactionRepository _transactionRepository;

        public PaymentService(ITransactionRepository transactionRepository)
        {
            this._transactionRepository = transactionRepository;
        }

    }
}