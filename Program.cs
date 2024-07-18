using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nosso Programa em C#");
            Personagem player1 = new Personagem("Joaquim", 40.5, 150);
            Orc player2 = new Personagem("João", 60.4, 170, 100);

            Console.WriteLine(player1.Nome);
            player1.Nome = "João";
            Console.WriteLine(player1.Nome);
        }
    }
}

class Personagem
{
    private string nome;
    private double peso;
    private int altura;

    public Personagem(string nome, double peso, int altura)
    {
        this.nome = nome;
        this.peso = peso;
        this.altura = altura;
    }

    //Getters e Setters
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public double Peso
    {
        get { return peso; }
        set { peso = value; }
    }

    public int Altura
    {
        get { return altura; }
        set { altura = value; }
    }
}

class Orc : Personagem
{
    private int vigor;
    public Orc(string nome, double peso, int altura, int vigor) : base(nome, peso, altura)
    {
        this.vigor = vigor;
    }


    //Getters e Setters
    public int Vigor
    {
        get { return vigor; }
        set { vigor = value; }
    }
}