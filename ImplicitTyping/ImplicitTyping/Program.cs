using System;
using System.Text;

namespace ImplicitTyping
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "jhon";
            var lastNmae="Doe";

            var age = 15;
            int oldAge;

            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            var stringBuilder = new StringBuilder();

            Console.WriteLine(stringBuilder);
        }
    }
}
