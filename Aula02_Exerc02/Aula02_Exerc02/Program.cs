using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02_Exerc02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            PrintaEmAzul("Teste");
            Console.WriteLine("Testse");
            Console.ReadKey();
        }
        static int Soma3Numeros(int n1,int n2,int n3)
        {
            int resultado = n1 + n2 + n3;
            return resultado;
        }

        static void PrintaEmAzul(string texto)
        {
            ConsoleColor x;
            x = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(texto);
            Console.ForegroundColor = x;
            //Console.ResetColor();
        }
    }
}
