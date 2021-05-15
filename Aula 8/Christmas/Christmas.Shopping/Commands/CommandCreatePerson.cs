using Christmas.Entities;
using Christmas.Patterns;

namespace Christmas.Shopping.Commands
{
    class CommandCreatePerson : ICommand
    {
        public CommandCreatePerson(string name = "Person")
        {
            Name = name;
        }

        public string Name { get; set; }

        public Person Person { get; private set; }

        public void Execute()
        {
            Person = new Person { Name = Name };
        }

        public void Undo()
        {
            Person = null;
        }

        public void Redo()
        {
            Execute();
        }
    }
}