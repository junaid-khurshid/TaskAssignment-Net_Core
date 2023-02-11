using TaskAssignmentApplication.Service.Models;

namespace TaskAssignmentApplication.Models
{
    public class TransactionRequest
    {
        public int ProcessingCode { get; set; }
        public int SystemTraceNr { get; set; }
        public int FunctionCode { get; set; }
        public long CardNo { get; set; }
        public string CardHolder { get; set; }
        public int AmountTrxn { get; set; }
        public int CurrencyCode { get; set; }

        internal TransactionDetails ToDto() =>
            new TransactionDetails
            {
                ProcessingCode = ProcessingCode,
                SystemTraceNr = SystemTraceNr,
                FunctionCode = FunctionCode,
                CardNo = CardNo,
                CardHolder = CardHolder,
                AmountTrxn = AmountTrxn,
                CurrencyCode = CurrencyCode
            };
    }
}
