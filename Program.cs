using System;
using character;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RPG em C#\n");
            Orc player1 = new Orc("Legolas");

            Console.WriteLine(player1.Name);
            Console.WriteLine(player1.Hp);

            player1.Name += " Folha Verde";
            player1.Hp = 1000;
            player1.Mana = 100;

            Console.WriteLine("\nPersonagem Criado");
            Console.WriteLine(player1.Name);
            Console.WriteLine(player1.Hp);
            Console.WriteLine(player1.Mana);
        }
    }
}





