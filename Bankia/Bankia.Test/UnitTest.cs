using Bankia.Domain;
using System;
using System.Linq;
using Xunit;

namespace Bankia.Test
{

    /* xUnit follows Arrange -> Act -> Assert pattern */

    public class UnitTest
    {

        [Fact]
        public void OpeningBalance_CreatesOpeningDepositTransaction()
        {

            var acc = new BankAccount("ACC-X01", "John Doe", AccountType.Checking, openingBalance: 100m);

            Assert.Equal(100m, acc.Balance);
            Assert.Single(acc.History);

            var t = acc.History[0];
            Assert.Equal(TransactionType.Deposit, t.transactionType);
            Assert.Equal(100m, t.amount);
            Assert.Equal(100m, t.balanceAfter);
            Assert.Contains("Opening", t.notes ?? "");
        }

        [Fact]
        public void Deposit_IncreasesBalance_AndLogsTransaction()
        {
            // 1) Arrange – set up objects
            var acc = new BankAccount("ACC-X02", "Jane Doe", AccountType.Checking);
            
            // 2️) Act – perform some action
            acc.Deposit(60m, "paycheck");

            // 3️ Assert – verify the expected result
            Assert.Equal(60m, acc.Balance);
            Assert.Single(acc.History);

            var t = acc.History[0];
            Assert.Equal(TransactionType.Deposit, t.transactionType);
            Assert.Equal(60m, t.amount);
            Assert.Equal(60m, t.balanceAfter);
            Assert.Equal("paycheck", t.notes);
        }

        [Fact]
        public void Withdraw_DecreasesBalance_AndLogsTransaction()
        {
            var acc = new BankAccount("ACC-X03", "Jonas Doe", AccountType.Checking, 100m);
            acc.Withdraw(40m, "groceries");

            Assert.Equal(60m, acc.Balance);
            Assert.Equal(2, acc.History.Count); // opening + withdraw

            var t = acc.History.Last();
            Assert.Equal(TransactionType.Withdraw, t.transactionType);
            Assert.Equal(40m, t.amount);
            Assert.Equal(60m, t.balanceAfter);
            Assert.Equal("groceries", t.notes);
        }

        [Fact]
        public void Withdraw_WithInsufficientFunds_Throws()
        {
            var acc = new BankAccount("ACC-X04", "Fred Doe", AccountType.Checking, 10m);
            var ex = Assert.Throws<InvalidOperationException>(() => acc.Withdraw(20m));
            Assert.Contains("Insufficient", ex.Message);
        }

        [Fact]
        public void Transfer_UpdatesBothAccounts_AndLogsOutAndIn()
        {
            var source = new BankAccount("SRC", "Alice", AccountType.Checking, 100m);
            var dest = new BankAccount("DST", "Bob", AccountType.Savings, 50m);

            source.TransferTo(dest, 50m, "move to savings");

            // Balances
            Assert.Equal(50m, source.Balance);
            Assert.Equal(100m, dest.Balance);

            // Optional: check latest entries for clarity
            var srcLast = source.History.Last();
            var dstLast = dest.History.Last();
            Assert.Equal(TransactionType.TransferOut, srcLast.transactionType);
            Assert.Equal(TransactionType.TransferIn, dstLast.transactionType);
            Assert.Contains("To DST", srcLast.notes ?? "");
            Assert.Contains("From SRC", dstLast.notes ?? "");
        }

        [Fact]
        public void Amounts_MustBePositive()
        {
            var acc = new BankAccount("ID1", "Owner", AccountType.Checking);

            Assert.Throws<ArgumentOutOfRangeException>(() => acc.Deposit(0m));
            Assert.Throws<ArgumentOutOfRangeException>(() => acc.Deposit(-1m));
            Assert.Throws<ArgumentOutOfRangeException>(() => acc.Withdraw(0m));
            Assert.Throws<ArgumentOutOfRangeException>(() => acc.Withdraw(-1m));
        }

        [Fact]
        public void CannotTransferToSameAccount()
        {
            var acc = new BankAccount("ID1", "Owner", AccountType.Checking, 100m);
            var ex = Assert.Throws<InvalidOperationException>(() => acc.TransferTo(acc, 10m));
            Assert.Contains("same account", ex.Message, StringComparison.OrdinalIgnoreCase);
        }
    }
}