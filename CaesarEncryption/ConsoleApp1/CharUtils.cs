namespace Buz.Jg22.Main
{
    public static class CharUtils
    {
        public static bool IsUpperCase(char c)
        {
            return c >= 'A' && c <= 'Z';
        }

        public static bool IsLowerCase(char c)
        {
            return c >= 'a' && c <= 'z';
        }

        public static bool IsLetter(char c)
        {
            return IsLowerCase(c) || IsUpperCase(c);
        }

        public static bool IsNumber(char c)
        {
            return c >= '0' && c <= '9';
        }
    }
}
