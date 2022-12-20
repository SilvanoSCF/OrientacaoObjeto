using System;

class Pessoa
{

    public double peso;

    public double altura;


    //Metodo para calculo de massa corporal (IMC)
   public double IMC()
   {
        return peso / (altura * altura);
   }

   public string situacao(double IMC)
   {
       return IMC < 18.5 ? "Abaixo do peso !!!": IMC < 25 ? "Peso Normal" : IMC <30  ? "acima" : IMC < 35 ? " o1" : IMC < 40 ? "O2" : "O3" ;
       
   }

   public void mensagem()
   {
       double IMCs = IMC();

       string ObterSituacao = situacao(IMCs);

       Console.WriteLine(" portanto vc está "+ObterSituacao+" com média "+IMCs);

   }

    

    

}