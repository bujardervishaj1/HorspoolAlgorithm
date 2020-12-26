using System;

namespace HorspoolAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern1 = "abcd";
            var text1 = "abdebcabddeabcd";
            var indexOfMatching1 = Horspool.HorspoolMatching(pattern1, text1);
            Console.WriteLine($"Indexi per rastin 1: {indexOfMatching1}");

            var pattern2 = "ATGTA";
            var text2 = "GTACTAGAGGACGTATGTACTG";
            var indexOfMatching2 = Horspool.HorspoolMatching(pattern2, text2);
            Console.WriteLine($"Indexi per rastin 2: {indexOfMatching2}");

            var pattern3 = "kur";
            var text3 = "saeshteorakurfillonmesimi";
            var indexOfMatching3 = Horspool.HorspoolMatching(pattern3, text3);
            Console.WriteLine($"Indexi per rastin 3: {indexOfMatching3}");

            var pattern4 = "talked";
            var text4 = "howtospeakwithouttalking";
            var indexOfMatching4 = Horspool.HorspoolMatching(pattern4, text4);
            Console.WriteLine($"Indexi per rastin 4: {indexOfMatching4}");

            var pattern5 = "qwert";
            var text5 = "qwertyuiopasdfghjklzxcvbnmqwert";
            var indexOfMatching5 = Horspool.HorspoolMatching(pattern5, text5);
            Console.WriteLine($"Indexi per rastin 5: {indexOfMatching5}");
        }
    }
}
