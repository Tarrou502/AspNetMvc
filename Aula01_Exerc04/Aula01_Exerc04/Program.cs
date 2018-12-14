using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01_Exerc04
{
    class Program
    {
        static void Main(string[] args)
        {
            String _s ="";
            
            while (!_s.ToUpper().Equals("OI"))
            {
                Console.WriteLine("Digite um texto ou Oi para sair");
                _s = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
