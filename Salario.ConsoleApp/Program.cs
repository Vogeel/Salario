using System;

namespace Salario.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saláraio bom é salário alto!");

            Console.WriteLine("Qual seu salário atual? ");

            double inicial = double.Parse(Console.ReadLine());

            double final = inicial * 1.15;

            double final2 = final * 0.92;

            Console.WriteLine($"Seu novo salário ficou R${final:F2}, porem com os impostos, ficou R${final2:F2}");

            Console.ReadLine();
        }
    }
}
