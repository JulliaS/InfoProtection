using Common;
using System;

namespace Task1
{
    public class Crypter : ICrypter
    {
        private readonly ICoder _coder;

        public Crypter(ICoder coder)
        {
            _coder = coder;
        }
        public string Encrypt(string message, object key, Language language) => _coder.CodeEncode(message, key, language);

        public string Decrypt(string message, object key, Language language) => _coder.CodeEncode(message, -Convert.ToInt32(key), language);


      
    }
}
