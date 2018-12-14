using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01_Exerc03
{
    class Program
    {
        static void Main(string[] args)
        {
            String _s;
            int _num;
            while (true)
            {
                Console.WriteLine("Digite um numero ou S para sair");
                _s =Console.ReadLine ();

                if (_s.Equals("S"))
                    break;
                _num = int.Parse(_s);
                if (_num % 2 == 0)
                    Console.WriteLine("{0} é par",_num);
                else
                    Console.WriteLine("{0} é impar",_num);

            }
            Console.ReadKey();
        }
    }
}
