using System;

namespace PolessUpProject_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Parts = { "    +\"\"\"\"\"+ ", "   (| o o |)", "    |  ^  | ", "    | '-' | ", "    +-----+" };
            for (int i = 0; i < Parts.Length; i++)
            {
                Console.WriteLine(Parts[i]);
            }
        }
    }
}
