namespace BookCover
{
    public interface IBook
    {
        string Title { get; }
        string Author { get; }
        IBinding Binding { get; }
    }
}