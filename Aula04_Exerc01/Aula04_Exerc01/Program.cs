using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04_Exerc01
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor p = new Professor("Leo");
            Recepcionista r = new Recepcionista("Silvia");

            
            //p.Trabalhar();
            PorParaTrabalhar(p);
            PorParaTrabalhar(r);

            Console.ReadKey();
        }

        static void PorParaTrabalhar(Funcionario f)
        {
            Console.WriteLine("Nome " + f.Nome);
            f.Trabalhar();
        }
    }

    public class Funcionario
    {
        public String Nome { get; protected set; }
        public String Cargo { get; protected set; }
        public void Trabalhar()
        {
            Console.WriteLine("Tomando Café");
        }

    }

    public class Professor : Funcionario
    {

        public Professor(string nome)
        {
            Cargo = "Professor";
            Nome = nome;
        }

        // new utilizado para suprir warning, quando estamos reescrevendo
        new public void Trabalhar()
        {
            Console.WriteLine("Ensinando");
        }
    }

    public class Recepcionista : Funcionario
    {

        public Recepcionista(string nome)
        {
            Cargo = "Recepcionista";
            Nome = nome;
        }

        // new utilizado para suprir warning, quando estamos reescrevendo
        new public void Trabalhar()
        {
            Console.WriteLine("Atender clientes...");
        }
    }

    /*------------------------------------------------
      Classe abstrata

    */
    public abstract class Funcionario2
    {
        public String Nome;
        public String Cargo;
        public abstract void Trabalhar();

    }

    public class Professor2 : Funcionario2
    {

        public Professor2(string nome)
        {
            Cargo = "Professor";
            Nome = nome;
        }

     
        public override void Trabalhar()
        {
            throw new NotImplementedException();
        }
    }

    /*
     * Quando a classe pai tem construtor
     * A classe filha para tem construtor deve usar base
     */

    public class Funcionario3
    {
        public String Nome { get; protected set; }
        public String Cargo { get; protected set; }
        public Funcionario3(string nome)
        {

        }

        public void Trabalhar()
        {
            Console.WriteLine("Tomando Café");
        }

    }

    // Selead : força  que não posso herdar de Professor3
    public sealed class Professor3 : Funcionario3
    {

        public Professor3(string nome):base("nome")
        {
            Cargo = "Professor";
            Nome = nome;
        }

        // new utilizado para suprir warning, quando estamos reescrevendo o metodo
        new public void Trabalhar()
        {
            Console.WriteLine("Ensinando");
        }
    }

}
