using Bankia.Domain;

namespace Bankia.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Bankia.System");

            var account1 = new BankAccount("ACC-001", "Gonçalo", AccountType.Checking, 200m);
            var account2 = new BankAccount("ACC-002", "Savings", AccountType.Savings, 50m);
            var account3 = new BankAccount("ACC-003", "Ana", AccountType.Checking, 50m);

            account1.Deposit(50m, "Paycheck");
            account1.Withdraw(25m, "Groceries + Rent");
            account1.TransferTo(account2, 10m, "Move to savings");

            // random ops

            account1.Deposit(1200m, "Freelance Payment");
            account1.Withdraw(150m, "Utilities and Groceries");
            account1.TransferTo(account2, 300m, "Emergency Fund");
            account1.Deposit(200m, "Refund from Store");
            account1.Withdraw(80m, "Dining Out");
            account2.Deposit(500m, "Interest Payment");
            account2.Withdraw(50m, "Gift Purchase");
            account2.TransferTo(account1, 100m, "Shared Expenses");
            account1.Withdraw(25m, "Coffee Subscription");
            account1.TransferTo(account3, 200m, "Family Support");

            Print(account1);
            Print(account2);
            Print(account3);

            static void Print(BankAccount acc)
            {
                Console.WriteLine($"\n[{acc.Id}] {acc.OwnerName} - {acc.AccountType} | Balance: {acc.Balance:C}");
                foreach (var t in acc.History)
                    Console.WriteLine($"{t.timestamp:HH:mm:ss} {t.transactionType,-12} {t.amount,8:C} → Bal: {t.balanceAfter,8:C} {t.notes}");
            }

            Console.WriteLine("Final balance in Gonçalo Checking: " + account1.Balance);
            Console.WriteLine("Final balance in Gonçalo Savings: " + account2.Balance);
            Console.WriteLine("Final balance in Ana Checking: " + account3.Balance);

        }
    }
}
