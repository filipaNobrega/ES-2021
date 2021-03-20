namespace Logging
{
    public interface IFileSystem
    {
        void WriteLine(string path, string contents);
    }
}