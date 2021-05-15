using Christmas.Entities;
using Christmas.Patterns;

namespace Christmas.Shopping.Commands
{
    class CommandModifyName : ICommand
    {
        public CommandModifyName(Receiver receiver, string name)
        {
            Receiver = receiver;
            Name = name;
        }

        public string Name { get; set; }

        public Receiver Receiver { get; }

        public void Execute()
        {
            var name = Receiver.Name;
            Receiver.Name = Name;
            Name = name;
        }

        public void Undo()
        {
            Execute();
        }

        public void Redo()
        {
            Execute();
        }
    }
}