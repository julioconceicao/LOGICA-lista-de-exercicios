using System;

namespace caixa_retangular
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float cxVolume, cxComprimento, cxLargura, cxAltura;

            Console.WriteLine("Digite o comprimento da caixa em metros: ");
            cxComprimento = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a largura da caixa em metros: ");
            cxLargura = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a altura da caixa em metros: ");
            cxAltura = float.Parse(Console.ReadLine());

            cxVolume = cxComprimento * cxLargura * cxAltura;

            Console.WriteLine($"O volume da caixa é: {cxVolume} metros cúbicos.");
            
        }
    }
}
