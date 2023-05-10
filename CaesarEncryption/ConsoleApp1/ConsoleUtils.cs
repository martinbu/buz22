namespace Buz.Jg22.Main
{
    public static class ConsoleUtils
    {
        public static string ReadStringFromConsole(string label)
        {
            Console.Write(label);
            return Console.ReadLine();
        }

        public static int ReadIntFromConsole(string label, string errorTextIfNoInt)
        {
            bool success = false;
            while (!success)
            {
                Console.Write(label);
                string userInput = Console.ReadLine();

                success = int.TryParse(userInput, out int intNumber);
                if (success)
                {
                    return intNumber;
                }

                Console.WriteLine(errorTextIfNoInt);
            }

            return 0;
        }
    }
}
