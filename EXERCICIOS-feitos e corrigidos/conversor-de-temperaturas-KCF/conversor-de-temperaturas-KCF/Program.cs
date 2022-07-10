using System;

namespace conversor_de_temperaturas_KCF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double K, C, F;

            Console.WriteLine("Digite a temperatura em Fahrenheit: ");
            F = Convert.ToDouble(Console.ReadLine());

            C = (F - 32) * 5 / 9;

            K = (F - 32) * 5 / 9 + 273.15;

            Console.WriteLine($"A temperatura em Celsius é: {C} ");
            
            Console.WriteLine($"A temperatura em Kelvin é: {K} ");

        }
    }
}
