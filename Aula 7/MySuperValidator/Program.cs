using System;

namespace MySuperValidator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const string s1 = "potato";
            const string s2 = "oo";
            const string s3 = "xyz";
            // Using the Interpreter Pattern to define an "expression" class hierarchy to interpret sentences in the language.
            // The expression objects are composed recursively into a tree structure (Composite pattern).
            IValidator validator = new Or(new And(new LengthGreaterThan(5), new LengthLesserThan(8)), new LengthEqualTo(2));
            var b1 = validator.IsValid(s1); // output: true
            var b2 = validator.IsValid(s2); // output: true
            var b3 = validator.IsValid(s3); // output: false
            Console.WriteLine($"'{s1}' IsValid returned {b1}");
            Console.WriteLine($"'{s2}' IsValid returned {b2}");
            Console.WriteLine($"'{s3}' IsValid returned {b3}");
        }
    }
}