using System.Threading.Tasks;
using TaskAssignmentApplication.Service.Models;

namespace TaskAssignmentApplication.Service.IServices
{
    public  interface ITransactionsService
    {
        Task<TransactionResponse> AddTransactionAsync(TransactionDetails transactionDetails);
    }
}
