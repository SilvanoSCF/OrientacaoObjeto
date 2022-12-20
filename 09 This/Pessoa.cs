using System;


class Pessoa
{
    //Atributo
    private string nome = "Tatiana";

    //Contrutor
    public Pessoa(string nome)
    {
        Console.WriteLine(nome); // A referencia neste caso seria nome de dentro do contrutor
        Console.WriteLine(this.nome); //A referencia aqui busca no atributo
    }







}