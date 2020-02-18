using System;

namespace HandsOn_LoopFor
{
    class Program
    {
        static void Main(string[] args)
        {
            for(var i =1; i <= 50; i++)
            {
                var parOuImpar = (i % 2 == 0) ? "par" : "ímpar";
                Console.WriteLine($"{i} {parOuImpar}");
            }
        }
    }
}
