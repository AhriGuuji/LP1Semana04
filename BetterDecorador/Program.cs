using System;

namespace BetterDecorador
{
    /// <summary>
    /// This program is used to create a decorated string
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The launcher to start commands on the system.
        /// </summary>
        /// <param name="args">The arguments to use in certain parameters</param>
        private static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine(Decor("User did not specify args !", '=', 3));
                return;
            }
            Console.WriteLine(Decor(args[0],char.Parse(args[1]),int.Parse(args[2]))); //Print Decor
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
        private static string Decor()
        {
            return Decor("User did not specify args !", '=', 3);
        }
    }
}