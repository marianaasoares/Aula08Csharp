using System;

namespace HandsOn_FimdeSemana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe uma data e eu direi se é dia de semana ou fim de semana: ");
            var diaUsuario = Convert.ToDateTime(Console.ReadLine());

            var diaDaSemana = (int)diaUsuario.DayOfWeek;

            string dia;

            switch (diaDaSemana)
            {
                case 0:
                case 6:
                    dia = "Fim de semana";
                    break;
                default:
                    dia = "Dia útil";
                    break;
            }

            Console.WriteLine($"O dia informado '{diaUsuario: dd/mm/yyyy}' é um {dia}");
        }
    }
}
