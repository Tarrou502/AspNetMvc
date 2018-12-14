using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<Pessoa> listaP = new List<Pessoa>();
            Pessoa p1 = new Pessoa("Leo", 28);
            listaP.Add(p1);

            Pessoa p2 = new Pessoa("Fabio", 23);
            listaP.Add(p2);

            foreach(Pessoa p  in listaP){
                Console.WriteLine("Nome:{0}   Idade:{1}", p.Nome, p.Idade);
            }

            Queue<int> fila = new Queue<int>();
            fila.Enqueue(2);
            fila.Enqueue(8);
            fila.Enqueue(1);
            fila.Enqueue(6);

            Console.WriteLine("-------- Fila ");
            while (fila.Count> 0) { 
               Console.WriteLine ( fila.Dequeue());
            }
            Console.ReadKey();

            Dictionary<string, Pessoa> dicionario
                = new Dictionary<string, Pessoa>();
            dicionario.Add(p1.Nome, p1);
            bool contem = dicionario.ContainsKey(p1.Nome);
            Pessoa valor = dicionario[p1.Nome];


            Stack<Pessoa> pilha = new Stack<Pessoa>();
            pilha.Push(p1);
            Pessoa item = pilha.Pop();
            */
            List<Pessoa> lista2 = new List<Pessoa>();
            Pessoa p3 = new Pessoa("Leo", 28);
            lista2.Add(p3);

             p3 = new Pessoa("Fabio", 23);
            lista2.Add(p3);

            foreach (Pessoa p in lista2)
            {
                Console.WriteLine("Nome:{0}   Idade:{1}", p.Nome, p.Idade);
            }
            Console.WriteLine("---> apos");

            p3.Nome = "Jose";
            p3.Idade = 1;
            foreach (Pessoa p in lista2)
            {
                Console.WriteLine("Nome:{0}   Idade:{1}", p.Nome, p.Idade);
            }
            Console.ReadKey();
        }
    }

    public class Pessoa
    {
        public String Nome;
        public int Idade;
        

        public Pessoa(String Nome, int Idade){
            this.Nome = Nome;
            this.Idade = Idade;
        }

        
    }
    
}
