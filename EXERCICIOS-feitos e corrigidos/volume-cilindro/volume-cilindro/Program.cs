using System;

namespace volume_cilindro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r, h, v;
            Console.WriteLine("Digite o raio do cilindro: ");
            r = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a altura do cilindro: ");
            h = double.Parse(Console.ReadLine());

            v = Math.PI * Math.Pow(r, 2) * h;
            Console.WriteLine("O volume do cilindro é: " + v);

        }
    }
}
