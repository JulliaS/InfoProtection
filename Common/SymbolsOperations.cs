using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class SymbolsOperations
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

        public static string BoolListToBitString(List<bool> bitArray)
        {
            var sb = new StringBuilder();
            foreach (var bit in bitArray)
            {
                sb.Append(Convert.ToInt32(bit));
            }
            
            return sb.ToString();
        }
    }
}
