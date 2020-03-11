using Common;
using System.Collections.Generic;

namespace Task3
{
    internal class Crypter : ICrypter
    {
        private VigenerCoder _vigenerCoder;

        public Crypter(VigenerCoder vigenerCoder)
        {
            _vigenerCoder = vigenerCoder;
        }

        public string Decrypt(string message, object key, Language language) => _vigenerCoder.CodeEncode(message, key, language);

        public string Encrypt(string message, object key, Language language) => _vigenerCoder.CodeEncode(message, key, language);
    }
}