using System;

namespace BetterDecorador
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length == 3)
            {
                string str = args[0];
                char Char = char.Parse(args[1]);
                Console.WriteLine(Decor(str, Char, int.Parse(args[2])));
            }
            else
            {
                Console.WriteLine(Decor());
            }
        }

        private static string Decor(string s, char dec, int n)
        {
            string decor = new string(dec, n);
            return $"{decor}{s}{decor}";
        }

        private static string Decor()
        {
            return Decor("DefaultString", '*', 3);
        }
    }
}
