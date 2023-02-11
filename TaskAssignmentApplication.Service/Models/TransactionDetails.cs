﻿namespace TaskAssignmentApplication.Service.Models
{
    public class TransactionDetails
    {
        public int ProcessingCode { get; set; }
        public int SystemTraceNr { get; set; }
        public int FunctionCode { get; set; }
        public long CardNo { get; set; }
        public string CardHolder { get; set; }
        public int AmountTrxn { get; set; }
        public int CurrencyCode { get; set; }
    }
}
