using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01_Exerc02
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um numero");
                int a = int.Parse(Console.ReadLine());
                if (a > 0)
                    Console.WriteLine(" O número {0} é positivo", a);
                else if (a == 0)
                    Console.WriteLine(" O número é zero");
                else
                    Console.WriteLine(" O número {0} é negativo", a);
            

            Console.ReadKey();

        }
    }
}
