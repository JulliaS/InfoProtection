using System;

namespace Common
{
    public class LettersOperations
    {
        private const string UkAlphabet = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ";
        private const string EnAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public static string GetAlphabet(Language language)
        {
            switch (language)
            {
                case Language.English:
                    return EnAlphabet;
                case Language.Ukrainian:
                    return UkAlphabet;
                default:
                    throw new ArgumentException("We don't speak your language!");
            }
        }

        public static char GetLetterWithProperRegister(char originalLetter, char codedLetter)
        {
            if (char.IsUpper(originalLetter))
            {
                codedLetter = char.ToUpper(codedLetter);
            }
            else
            {
                codedLetter = char.ToLower(codedLetter);
            }
            return codedLetter;
        }
    }
}
