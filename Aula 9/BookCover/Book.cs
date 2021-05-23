using System;
using System.Collections.Generic;
using System.Text;

namespace BookCover
{
    abstract class Book : IBook
    {
        protected Book(string title, string author, IBinding binding)
        {
            Title = title;
            Author = author;
            Binding = binding;
        }

        public string Title { get; }
        public string Author { get; }
        public IBinding Binding { get; }
        public override string ToString()
        {
            return $"Created {Title} by {Author} using {Binding.Name}";
        }
    }
}
