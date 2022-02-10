using System;

namespace KataFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz test");
            FizzBuzzCounter fb = new();
            fb.Counter(30).ForEach(s => Console.WriteLine(s));
            Console.ReadKey();
        }
    }
}
