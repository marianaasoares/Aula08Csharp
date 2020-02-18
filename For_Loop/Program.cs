using System;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {

            for (var i = 0; i < 11; i++)
            {
                Console.WriteLine($"i = {i}");
            }

            var idade = 18;
            idade = idade + 5;
            idade += 5;

            for (var i = 10; i >0; i -= 2)
            {
                if (i == 8)
                    continue;

                Console.WriteLine($"i = {i}");

                if (i == 6) break;
            }
            
        }
    }
}
