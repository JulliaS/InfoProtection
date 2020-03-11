namespace Common
{
    public interface ICrypter
    {
        string Encrypt(string message, object key, Language language);

        string Decrypt(string message, object key, Language language);
    }
}
