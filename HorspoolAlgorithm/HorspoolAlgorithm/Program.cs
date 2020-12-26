using System;

namespace HorspoolAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {

            var horspool = new Horspool("abcd", "abdebcabddeabcd");
            var startingIndexOfMatching = horspool.HorspoolMatching();


            Console.WriteLine("Hello World!");
        }
    }
}
