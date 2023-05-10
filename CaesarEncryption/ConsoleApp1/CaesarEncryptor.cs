namespace Buz.Jg22.Main
{
    public class CaesarEncryptor
    {
        public static string Encrypt(string textToEncrypt, int key)
        {
            return CalculateCaesarText(textToEncrypt, key, encrypt: true);
            // test
        }

        public static string Decrypt(string textToEncrypt, int key)
        {
            return CalculateCaesarText(textToEncrypt, key, encrypt: false);
        }

        private static string CalculateCaesarText(string text, int key, bool encrypt)
        {
            int direction = encrypt ? 1 : -1;

            int numberAlphabetLength = 10 * direction;
            int letterAlphabetLength = 26 * direction;

            int numberKey = (key % numberAlphabetLength) * direction;
            int letterKey = (key % letterAlphabetLength) * direction;

            char[] textArray = text.ToArray();

            for (int i = 0; i < textArray.Length; i++)
            {
                char sourceChar = textArray[i];

                int alphabetLength;
                int keyForChar;

                if (CharUtils.IsNumber(sourceChar))
                {
                    alphabetLength = numberAlphabetLength;
                    keyForChar = numberKey;
                }
                else if (CharUtils.IsLetter(sourceChar))
                {
                    alphabetLength = letterAlphabetLength;
                    keyForChar = letterKey;
                }
                else
                {
                    continue;
                }

                int movedChar = sourceChar + keyForChar;
                if (IsCharOutOfRange(sourceChar, movedChar))
                {
                    movedChar -= alphabetLength;
                }

                textArray[i] = (char)movedChar;
            }

            return string.Join("", textArray);
        }

        private static bool IsCharOutOfRange(char sourceChar, int movedChar)
        {
            if (movedChar < 0 || movedChar > 127) return true;

            if (CharUtils.IsNumber(sourceChar) && !CharUtils.IsNumber((char)movedChar)) return true;
            if (CharUtils.IsLowerCase(sourceChar) && !CharUtils.IsLowerCase((char)movedChar)) return true;
            if (CharUtils.IsUpperCase(sourceChar) && !CharUtils.IsUpperCase((char)movedChar)) return true;

            return false;
        }
    }
}
