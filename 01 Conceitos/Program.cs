using System;

namespace _01_Conceitos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Aula 4 
            
            Pessoa pessoa = new Pessoa();
            pessoa.nome = "Silvano";
            pessoa.cpf = "10377155780";
            pessoa.endereco = "Rua São Francisco 637";

            pessoa.mensagem();

        }
    }
}
