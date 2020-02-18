using System;

namespace LoopWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            var dado = new Random();
            var jogada = 0;

            while (jogada != 6)
            {
                jogada = dado.Next(1, 7);
                Console.WriteLine($"Jogada de dado: {jogada}");
            }
        }
    }
}
