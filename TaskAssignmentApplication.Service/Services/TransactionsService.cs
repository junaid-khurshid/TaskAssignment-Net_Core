using System;
using System.Threading.Tasks;
using TaskAssignmentApplication.Common.Helpers;
using TaskAssignmentApplication.Service.IServices;
using TaskAssignmentApplication.Service.Models;

namespace TaskAssignmentApplication.Services.Service
{
    public class TransactionsService : ITransactionsService
    {
        public TransactionsService()
        {

        }

        public async Task<TransactionResponse> AddTransactionAsync(TransactionDetails transactionDetails)
        {
            return new TransactionResponse
            {
                ResponseCode = 00,
                Message = "Success",
                ApprovalCode = int.Parse(RandomNumberGenerator.CreateRandomNumber(6)),
                DateTime = DateTime.Now.ToString("yyyyMddhhmm")

            };
        }
    }
}
