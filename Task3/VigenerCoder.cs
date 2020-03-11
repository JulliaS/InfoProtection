using Common;
using System;
using System.Linq;
using System.Text;

namespace Task3
{
    public class VigenerCoder : ICoder
    {

        public string CodeEncode(string text, object key, Language language)
        {
            var complexKey = key as ComplexKey;

            var alphabet = LettersOperations.GetAlphabet(language);

            var repeatedKey = GetRepeatKey(complexKey.Key, text);

            var result = new StringBuilder();
            var alphabetLenght = alphabet.Length;

            int i = 0;
            foreach (var letter in text)
            {
                var letterIndex = alphabet.IndexOf(char.ToUpper(letter));
                    
                if (letterIndex < 0)
                {
                    result.Append(letter.ToString());
                }
                else
                {
                    var codeIndex = alphabet.IndexOf(char.ToUpper(repeatedKey[i++]));

                    var index = (alphabetLenght + letterIndex + ((complexKey.Encrypting ? 1 : -1) * codeIndex)) % alphabetLenght;
                    var codedLetter = alphabet[index];

                    result.Append(LettersOperations.GetLetterWithProperRegister(letter, codedLetter));
                }
            }

            return result.ToString();
        }

        private string GetRepeatKey(string key, string text)
        {
            var copyKey = key;

            var onlyLetters = text.Where(x => char.IsLetter(x)).ToList();

            while (copyKey.Length < onlyLetters.Count)
            {
                copyKey += copyKey;
            }

            return copyKey.Substring(0, onlyLetters.Count);
        }
    }
}