using System;

namespace Fahrenheit_para_Ceusius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double C, F;

            Console.WriteLine("Digite a temperatura em Fahrenheit: ");
            F = Convert.ToDouble(Console.ReadLine());

            C = (F - 32) * 5 / 9;

            Console.WriteLine("A temperatura em Celsius é: " + C);
            

        }
    }
}
