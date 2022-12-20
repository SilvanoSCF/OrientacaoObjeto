using System;

namespace _05_Acesso
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            p.nome = "Silvano";

            //p.cpf sem acesso por ser Private
        }
    }
}
