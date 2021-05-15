using System;

namespace Christmas.Patterns
{
    public interface ICommand
    {
        void Execute();
        void Undo();
        void Redo();
    }
}
