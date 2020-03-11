using Common;
using System;

namespace Task2
{
    public class Crypter : ICrypter
    {
        private readonly ICoder _сoder;

        public Crypter(ICoder coder)
        {
            _сoder = coder;
        }

        public string Decrypt(string message, object key, Language language)
        {
            try
            {
                var compexKey = key as ComplexKey;

                var originalLetter = compexKey.OriginalLetter;
                var targetLetter = compexKey.TargetLetter;

                return message
                    .Replace(char.ToUpper(originalLetter), char.ToUpper(targetLetter))
                    .Replace(char.ToLower(originalLetter), char.ToLower(targetLetter));
            }
            catch (ArgumentException ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }

        public string Encrypt(string message, object key, Language language) => _сoder.CodeEncode(message, key, language);

    }
}