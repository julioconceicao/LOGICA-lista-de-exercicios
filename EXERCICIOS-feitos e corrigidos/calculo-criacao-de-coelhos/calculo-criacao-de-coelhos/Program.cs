using System;

namespace calculo_criacao_de_coelhos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double custo;
            int nCoelhos;

            Console.WriteLine("Informe o número de coelhos: ");
            nCoelhos = Int32.Parse(Console.ReadLine());

            custo = (nCoelhos * 20) / 28;

            Console.WriteLine($"{custo}");

        }
    }
}
