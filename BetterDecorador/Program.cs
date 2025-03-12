using System;

namespace BetterDecorador
{
    public class Program
    {
        /// <summary>
        /// The launcher to start commands on the system.
        /// </summary>
        /// <param name="args">The arguments to use in certain parameters</param>
        private static void Main(string[] args)
        {
            Console.WriteLine(Decor(args[0],char.Parse(args[1]),int.Parse(args[2])));
        }

/// <summary>
/// Create a decorated string.
/// </summary>
/// <param name="phrase">The phrase in the middle.</param>
/// <param name="decoration">The decoration char you want on each side.</param>
/// <param name="quantity">How many decoration char you want.</param>
/// <returns>Returns the decorated string to use on main</returns>
        private static string Decor(string phrase, char decoration, int quantity)
        {
            string characters = "";
            for (int i = 0; i < quantity; i++)
            {
                characters += decoration;
            }
            return $"{characters} {phrase} {characters}";
        }
    }
}