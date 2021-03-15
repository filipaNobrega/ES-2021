using System;
using System.IO;
using System.Linq;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Usage: Exercise4 <filename>");
                return;
            }

            try
            {
                var lines = File.ReadAllLines(args[0]);
                foreach (var line in lines)
                {
                    foreach (var character in line)
                    {
                        if (char.IsWhiteSpace(character))
                        {
                            continue;
                        }

                        Console.Write(char.ToUpper(character));
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
