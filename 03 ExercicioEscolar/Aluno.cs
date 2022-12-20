using System;

namespace _03_ExercicioEscolar
{
    class Aluno
    {
        //Atributos
        public string nome;        
        public double nota1, nota2;

        // Métodos ******

        // Média
        public double media()
        {
            return (nota1+nota2)/2;
        }
        //Situação
        public string situacao(double media)
        {
         return media >= 7 ? "Aprovado" : "Reprovado";
        }

        //Mensagens
        public void mensagem()
        {
            //Obter a media
            double obterMedia = media();

            //Obter Situação
            string obterSituacao = situacao(obterMedia);

            //Mensagem
            Console.WriteLine(nome+ " está "+obterSituacao+" com média "+obterMedia);

        }

        public void mensagem2()
        {
            double n1 = nota1;
            double n2 = nota2;
            string no = nome;

            double obterMedia = media();
            string obterSituacao = situacao(obterMedia);

             Console.WriteLine(nome+ " suas notas foram "+n1+" e "+n2+" portanto vc está "+obterSituacao+" com média "+obterMedia);

        }


    }

}

