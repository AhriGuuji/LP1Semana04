using System;

namespace BetterDecorador
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Decor(args[0],char.Parse(args[1]),int.Parse(args[2])));
        }

        private static string Decor(string x, char y, int z)
        {
            string characters = "";
            for (int i = 0; i < z; i++)
            {
                characters += y;
            }
            return $"{characters} {x} {characters}";
        }
    }
}