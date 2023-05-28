namespace Buz.Banking
{
    public class BankAccount : IBankAccount
    {
        public string Number => throw new NotImplementedException();

        public string Owner => throw new NotImplementedException();

        public decimal Balance => throw new NotImplementedException();

        private readonly List<Transaction> _Transaction;

        public BankAccount()
        {
            _Transaction = new List<Transaction>();
        }

        public string ExportTransactionsAsCsv(DateTime from, DateTime to)
        {
            return "";
        }

        public void MakeDeposit(decimal amount, string note, DateTime? date = null)
        {
            if (date == null)
            {
                date = DateTime.Now;
            }

            _Transaction.Add(new Transaction(amount, note, date.Value));
        }

        public void MakeWithdrawal(decimal amount, string note, DateTime? date = null)
        {
        }
    }
}
