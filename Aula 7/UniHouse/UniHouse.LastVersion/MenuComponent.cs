using System.Collections.Generic;

namespace UniHouse.LastVersion
{
    public abstract class MenuComponent : IMenuComponent
    {
        protected readonly IList<IMenuComponent> Children = new List<IMenuComponent>();

        protected MenuComponent(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; }
        public string Description { get; }

        public void Add(IMenuComponent child)
        {
            Children.Add(child);
        }

        public void Remove(IMenuComponent child)
        {
            Children.Remove(child);
        }

        public IMenuComponent GetChild(int index)
        {
            return Children[index];
        }
    }
}