using System;

class Aluno
{

    // Atributos
    private double nota1, nota2;

    //Métodos
    private double media()
    {
        return (nota1+nota2)/2;

    }

   

    public void mensagem()
    {
          Console.WriteLine("Informe o valor da primeira nota: ");
          nota1 = Convert.ToDouble(Console.ReadLine());

          Console.WriteLine("Informe o valor da segunda nota: ");
          nota2 = Convert.ToDouble(Console.ReadLine());

          Console.WriteLine("A média é: "+media());
          


    }

}