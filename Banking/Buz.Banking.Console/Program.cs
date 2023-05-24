namespace Buz.Banking.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sicherstellen, dass € zeichen auch ausgegeben wird
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            
            // new BankAccount("Vorname Nachname", 3500.50m);
            // Run(bankAccount);
        }

        static void Run(IBankAccount bankAccount)
        {
            bankAccount.MakeDeposit(500.20m, "Geld von einem Freund");
            bankAccount.MakeWithdrawal(22.50m, "Einkaufen Spar");

            System.Console.WriteLine("Balance of {0}({1}): {2:c}", bankAccount.Owner, bankAccount.Number, bankAccount.Balance);
        }
    }
}
