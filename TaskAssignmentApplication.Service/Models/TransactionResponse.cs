namespace TaskAssignmentApplication.Service.Models
{
    public class TransactionResponse
    {
        public int ResponseCode { get; set; }
        public string Message { get; set; }
        public int ApprovalCode { get; set; }
        public string DateTime { get; set; }
    }
}
