using System;

class Program
{
    static void Main(string[] args)
    {
        // Solicitar al usuario que ingrese los tres valores
        Console.WriteLine("Ingrese el primer valor:");
        double valor1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo valor:");
        double valor2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el tercer valor:");
        double valor3 = Convert.ToDouble(Console.ReadLine());

        // Calcular el promedio
        double promedio = (valor1 + valor2 + valor3) / 3;

        // Verificar si el promedio es mayor que 50
        if (promedio > 50)
        {
            Console.WriteLine($"El promedio es {promedio}, que es mayor que 50 puntos.");
        }
        else
        {
            Console.WriteLine($"El promedio es {promedio}, que no es mayor que 50 puntos.");
        }
    }
}
