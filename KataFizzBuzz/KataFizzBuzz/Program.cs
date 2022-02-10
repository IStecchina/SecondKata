using System;

namespace KataFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz test");
            FizzBuzzCounter fb = new();
            fb.PrintFizzBuzz(30);
            Console.ReadKey();
        }
    }
}
