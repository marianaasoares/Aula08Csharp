using System;

namespace HandOn_DataVencimento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a data da compra do produto: ");
            var dataCompra = Convert.ToDateTime(Console.ReadLine());

            var dataGarantia = dataCompra.AddYears(1);
            var prazoDeGarantia = (dataGarantia <= DateTime.Now) ? "fora" : "dentro";

            Console.WriteLine($"Seu produto está {prazoDeGarantia} da garantia");
        }
    }
}
