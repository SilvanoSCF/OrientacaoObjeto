using System;

namespace _11_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        
        {
            // Instancia Estagiário
            Imposto E = new Estagiario();
            E.valeAlimentacao(1000);
            E.valeTransporte(1000);
            Console.WriteLine("------------------");

            // Instancia Gerente
            Imposto G = new Gerente();
            G.valeAlimentacao(1000);
            G.valeTransporte(1000);
            Console.WriteLine("------------------");

            // Instancia Atendente
            Imposto A = new Atendente();
            A.valeAlimentacao(1000);
            A.valeTransporte(1000);
            Console.WriteLine("------------------");


        }
    }
}
