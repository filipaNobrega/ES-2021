using Christmas.Entities;
using Christmas.Patterns;

namespace Christmas.Shopping.Commands
{
    public class CommandCreateFamily : ICommand
    {
        public CommandCreateFamily(string name = "Family")
        {
            Name = name;
        }

        public string Name { get; set; }

        public Family Family { get; private set; }

        public void Execute()
        {
            Family = new Family { Name = Name };
        }

        public void Undo()
        {
            Family = null;
        }

        public void Redo()
        {
            Execute();
        }
    }
}