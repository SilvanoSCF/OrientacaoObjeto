using System;

namespace _03_ExercicioEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Aluno pessoa = new Aluno();

            pessoa.nome= "Silvano";
            pessoa.nota1= 8;
            pessoa.nota2 = 6;
            
            pessoa.mensagem();
            pessoa.mensagem2();
        }
    }
}
