using System;

class Program
{
    static void Main(string[] args)
    {
        rotar();

        Console.ReadLine();
    }

    static void rotar()
    {
        string numero = Console.ReadLine();
        char primero = numero[0];
        char segundo = numero[1];
        string resto = numero.Substring(2, numero.length - 2);
        string resultado = resto + primero + segundo;
        Console.WriteLine(resultado);
    }
}
