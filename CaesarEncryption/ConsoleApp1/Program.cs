using Buz.Jg22.Main;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            string userInput = ConsoleUtils.ReadStringFromConsole("Bitte gib einen Text ein der verschlüsselt werden soll: ");
            int key = ConsoleUtils.ReadIntFromConsole(
                label: "Bitte gib den key ein der verwendet werden soll um den Input Text zu verschlüsseln.\nKey: ",
                errorTextIfNoInt: "Das war keine Zahl. Der Key muss eine Zahl sein. Versuche es erneut.");

            string encryptedText = CaesarEncryptor.Encrypt(userInput, key);
            string decryptedTest = CaesarEncryptor.Decrypt(encryptedText, key);

            Console.WriteLine();
            Console.WriteLine("Der verschlüsselte Text lautet: {0}", encryptedText);
            Console.WriteLine("Der wieder entschlüsselte Text lautet: {0}", decryptedTest);
        }
    }
}