using Common;
using System;
using System.Text;

namespace Task1
{
    public class CaesarCoder : ICoder
    {
        public string CodeEncode(string text, object key, Language language)
        {
            int numberKey = Convert.ToInt32(key);
            var alphabet = SymbolsOperations.GetAlphabet(language);
            var lettersQuantity = alphabet.Length;
            var result = new StringBuilder();

            foreach (var letter in text)
            {
                var letterIndexInAlphabet = alphabet.IndexOf(char.ToUpper(letter));

                if (letterIndexInAlphabet < 0)
                {
                    result.Append(letter.ToString());
                }
                else
                {
                    var codedLetterIndexDirty = (lettersQuantity + letterIndexInAlphabet + numberKey) % lettersQuantity;

                    var codedLetterIndex = codedLetterIndexDirty >= 0
                        ? codedLetterIndexDirty
                        : (lettersQuantity + codedLetterIndexDirty);

                    var codedLetter = char.IsLower(letter)
                        ? char.ToLower(alphabet[codedLetterIndex])
                        : char.ToUpper(alphabet[codedLetterIndex]);

                    result.Append(codedLetter);
                }
            }

            return result.ToString();
        }
    }
}
