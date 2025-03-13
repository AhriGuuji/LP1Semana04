using System;

namespace Special
{
    public class Program
    {
        /// <summary>
        /// It will ask a number and put it on GetSpecial to show on the console.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            Console.Write("Insert n-th number of the special sequence: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetSpecial(number));
        }

/// <summary>
/// Recursivity: This method will check the n to get the next number of the sequence
/// </summary>
/// <param name="n">The number selected</param>
/// <returns>The result. The Next number of the seuquence.</returns>
    private static int GetSpecial(int n)
    {
        int result;
        if (n==0) {return 0;}
        else if (n==1) {return 1;}
        else
            result = GetSpecial(n-1)+2*GetSpecial(n-2);
            return result;
    }
    }
}
