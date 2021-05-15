using System.Collections.Generic;

namespace Christmas.Patterns
{
    /// <summary>
    /// A concrete command that contains a list of commands.
    /// The Execute method calls the execute method on each of the commands in the list.
    /// A sequence of commands - knows which commands to execute and in which order.
    /// </summary>
    public class MacroCommand : ICommand
    {
        private readonly List<ICommand> _commands = new List<ICommand>();

        public void Add(ICommand aCommand)
        {
            _commands.Add(aCommand);
        }

        public void Remove(ICommand aCommand)
        {
            _commands.Remove(aCommand);
        }

        public void Execute()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            _commands.Reverse();
            foreach (var command in _commands)
            {
                command.Undo();
            }
            _commands.Reverse();
        }

        public void Redo()
        {
            foreach (var command in _commands)
            {
                command.Redo();
            }
        }
    }
}