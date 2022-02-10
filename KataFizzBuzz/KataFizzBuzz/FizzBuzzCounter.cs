using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataFizzBuzz
{
    public class FizzBuzzCounter : IFizzBuzzCounter
    {
        public List<string> Counter(int input)
        {
            List<string> outputList = new();
            for (int i = 1; i <= input; i++)
            {
                outputList.Add(Translate(i));
            }
            return outputList;
        }

        public string Translate(int input)
        {
            return (input % 3 == 0, input % 5 == 0) switch
            {
                (false, false) => input.ToString(),
                (true, false) => "Fizz",
                (false, true) => "Buzz",
                (true, true) => "FizzBuzz"
            };
        }

    }
}
