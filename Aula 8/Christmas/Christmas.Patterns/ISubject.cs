namespace Christmas.Patterns
{
    public delegate void UpdateEventHandler(object sender, object data);
    public interface ISubject
    {
        event UpdateEventHandler OnUpdate;
    }
}