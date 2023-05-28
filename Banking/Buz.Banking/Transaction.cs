namespace Buz.Banking
{
    internal class Transaction
    {
        public Transaction(decimal amount, string note, DateTime time)
        {
            Amount = amount;
            Note = note;
            Time = time;
        }

        public decimal Amount { get; }
        public string Note { get; }
        public DateTime Time { get; set; }
    }
}
