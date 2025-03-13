using System;

namespace Special
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Insert n-th number of the special sequence: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetSpecial(number));
        }

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
