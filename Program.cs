using System;
using Figgle;
using Humanizer;

namespace NomeASCIIArt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Figgle: criando textos em ASCII art");
            Console.WriteLine("Digite seu nome");
            string SeuNome  = FiggleFonts.Standard.Render(Console.ReadLine());
            Console.WriteLine(SeuNome);
        }
    }
}
