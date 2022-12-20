using System;

class Pessoa
{

    public void apresentar()
    {
        Console.WriteLine("Olá");

    }

    public void apresentar(string nome)
    {
        Console.WriteLine("Olá "+nome+" !!!");

    }

    public void apresentar(string nome, int idade)
    {
        Console.WriteLine("Nome "+nome+" idade "+idade+".");
    }

   
}
