using System;
using System.Runtime.InteropServices;

namespace Special
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(GetSpecial(7));
        }

        private static int GetSpecial(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return GetSpecial(n - 1) + 2 * GetSpecial(n-2);
            }
        }
    }
}
