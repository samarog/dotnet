using System;

namespace Bankia.Domain

{
    public enum TransactionType
    {
        Deposit,
        Withdraw,
        TransferOut,
        TransferIn
    }

    public record Transaction(DateTime timestamp, TransactionType transactionType, decimal amount, decimal balanceAfter, string? notes = null);
}
