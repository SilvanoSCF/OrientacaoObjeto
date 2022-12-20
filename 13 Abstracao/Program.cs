using System;

namespace _13_Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();
            pf.taxaEmprestimo(1000.0);
            pf.calculoPoupanca(1000, 5);

            PessoaJuridica pj = new PessoaJuridica();
            pj.taxaEmprestimo(1000.0);
            pj.calculoPoupanca(1000, 5);

        


        }
    }
}
