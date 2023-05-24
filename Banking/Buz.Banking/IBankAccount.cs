namespace Buz.Banking
{
    public interface IBankAccount
    {
        string Number { get; }
        string Owner { get; }
        decimal Balance { get; }

        void MakeDeposit(decimal amount, string note, DateTime? date = null);
        void MakeWithdrawal(decimal amount, string note, DateTime? date = null);

        string ExportTransactionsAsCsv(DateTime from, DateTime to);
    }
}