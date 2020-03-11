namespace Common
{
    public interface ICoder
    {
        string CodeEncode(string text, object key, Language language);
    }
}
