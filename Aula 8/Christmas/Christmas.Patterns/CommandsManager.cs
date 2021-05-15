using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Christmas.Patterns
{
    public class CommandsManager
    {
        #region Singleton object holds the state for the lifetime of the application
        private CommandsManager() { }
        public static CommandsManager Instance { get; } = new CommandsManager();
        #endregion

        public event EventHandler Notify;

        private readonly List<ICommand> _commands = new List<ICommand>();

        private int _position = -1;

        public bool HasUndo => _position > -1;

        public bool HasRedo => _position < _commands.Count - 1;

        public void Execute(ICommand command)
        {
            Debug.Assert(command != null);

            if (HasRedo)
            {
                _commands.RemoveRange(_position + 1, _commands.Count - (_position + 1));
            }

            command.Execute();
            _commands.Add(command);
            _position++;

            Notify?.Invoke(this, EventArgs.Empty);
        }

        public void Undo()
        {
            if (!HasUndo) return;

            var command = _commands[_position];
            command.Undo();
            _position--;

            Notify?.Invoke(this, EventArgs.Empty);
        }

        public void Redo()
        {
            if (!HasRedo) return;
            _commands[++_position].Redo();

            Notify?.Invoke(this, EventArgs.Empty);
        }
    }
}