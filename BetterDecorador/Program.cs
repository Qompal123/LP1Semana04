using System;

namespace BetterDecorador
{
    public class Program
    {
        /// <summary>
        /// Entry point of the program.
        /// </summary>
        /// <param name="args">Command-line arguments. Expects 3 arguments: a string, a character, and an integer.</param>
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

        /// <summary>
        /// Decorates a string by surrounding it with a repeated character.
        /// </summary>
        /// <param name="s">The string to decorate.</param>
        /// <param name="dec">The character used for decoration.</param>
        /// <param name="n">The number of times the character is repeated on each side.</param>
        /// <returns>A new string with the decoration applied.</returns>
        private static string Decor(string s, char dec, int n)
        {
            string decor = new string(dec, n);
            return $"{decor}{s}{decor}";
        }

        /// <summary>
        /// Decorates a default string with a default character and count.
        /// </summary>
        /// <returns>A decorated default string.</returns>
        private static string Decor()
        {
            return Decor("DefaultString", '*', 3);
        }
    }
}
