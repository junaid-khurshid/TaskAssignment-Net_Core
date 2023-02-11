using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TaskAssignmentApplication.Models;
using TaskAssignmentApplication.Service.IServices;
using TaskAssignmentApplication.Service.Models;

namespace TaskAssignmentApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionsController : ControllerBase
    {
        private readonly ITransactionsService transactionsService;

        public TransactionsController(ITransactionsService transactionsService)
        {
            this.transactionsService = transactionsService ?? throw new System.ArgumentNullException(nameof(transactionsService));
        }

        [HttpPost]
        public async Task<TransactionResponse> AddNewTransactionAsync(TransactionRequest transactionRequest)
        {

            return await this.transactionsService.AddTransactionAsync(transactionRequest.ToDto());
        }
    }
}
