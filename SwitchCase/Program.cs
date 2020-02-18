using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu nome completo: ");
            var nomeCompleto = Console.ReadLine();

            Console.WriteLine("Informe o ódigo do seu cargo");
            var codigoCargo = int.Parse(Console.ReadLine());

            string nomeCargo;

            switch (codigoCargo)
            {
                case 600:
                    nomeCargo = "Gerente";
                    break;
                case 500:
                    nomeCargo = "Arquiteto";
                    break;
                case 400:
                    nomeCargo = "Tech Leader";
                    break;
                case 300:
                    nomeCargo = "Senior";
                    break;
                case 200:
                    nomeCargo = "Pleno";
                    break;
                case 100:
                    nomeCargo = "Junior";
                    break;
                default:
                    nomeCargo = "Outro";
                    break;
            }

            Console.WriteLine($"Prezado {nomeCompleto}, seu cargo é {nomeCargo}.");


        }
    }
}
