using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;

namespace Bankia.Domain
{
    public sealed class BankAccount
    {
        public string Id { get; set; }
        public string OwnerName { get; set; }
        public AccountType AccountType { get; set; }
        public decimal Balance { get; set; }

        private readonly List<Transaction> _history = new List<Transaction>();
        public ReadOnlyCollection<Transaction> History => _history.AsReadOnly();
        // ctor

        public BankAccount(string id, string ownerName, AccountType accountType, decimal openingBalance = 0m)
        {
            if (string.IsNullOrEmpty(id)) { throw new ArgumentNullException("A bank accoutn needs an id"); }

            if (string.IsNullOrEmpty(ownerName)) { throw new ArgumentNullException("A bank account needs an identifiable owner"); }

            if (accountType == null) { throw new ArgumentNullException(nameof(accountType)); }

            if (openingBalance < 0) { throw new ArgumentOutOfRangeException(nameof(openingBalance)); }

            Id = id;

            OwnerName = ownerName;

            AccountType = accountType;

            if (openingBalance > 0)
            {
                Deposit(openingBalance, "Opening balance"); // utiliza o método Deposit normal para a primeira transação. Faz sentido.

            }

        }

        public void RenameOwner(string newName)
        {
            if (string.IsNullOrEmpty(newName)) { throw new ArgumentNullException(nameof(newName)); }

            OwnerName = newName;
        }

        public void Deposit(decimal amount, string? notes = "Nada a declarar")
        {
            EnsurePositive(amount);

            Balance += amount;

            _history.Add(new Transaction(DateTime.UtcNow, TransactionType.Deposit, amount, Balance, notes));

        }

        public void Withdraw(decimal amount, string? notes = "Nada a declarar")
        {
            EnsurePositive(amount);

            if (amount > Balance)
            {
                throw new InvalidOperationException("Insufficient funds.");
            }

            Balance -= amount;

            _history.Add(new Transaction(DateTime.UtcNow, TransactionType.Withdraw, amount, Balance, notes));
        }

        public void TransferTo(BankAccount destination, decimal amount, string? notes = null)
        {

            if (destination is null) { throw new ArgumentNullException(nameof(destination)); }

            if (ReferenceEquals(this, destination)) throw new InvalidOperationException("Cannot transfer to the same account.");

            EnsurePositive(amount);

            if (amount > Balance) throw new InvalidOperationException("Insufficient funds.");

            Balance -= amount;

            _history.Add(new Transaction(DateTime.UtcNow, TransactionType.TransferOut, amount, Balance, $"To {destination.Id}. {notes}"));

            destination.TransferFrom(this, amount, notes);

        }

        public void TransferFrom(BankAccount origin, decimal amount, string? notes = null)
        {

            if (origin is null) { throw new ArgumentNullException(nameof(origin)); }

            if (ReferenceEquals(this, origin)) throw new InvalidOperationException("Cannot receive from the same account");

            EnsurePositive(amount);

            Balance += amount;

            _history.Add(new Transaction(DateTime.UtcNow, TransactionType.TransferIn, amount, Balance, $"From {origin.Id}. {notes}"));

        }

        public void EnsurePositive(decimal amount)

        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount must be positive.");
        }
    }
}
