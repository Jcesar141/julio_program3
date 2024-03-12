using System;

class Program
{
    static void Main(string[] args)
    {
        // Definir un vector de cinco dígitos
        int[] vector = { 1, 2, 3, 4, 5 };

        // Mostrar los números múltiplos de 3 en el vector
        Console.WriteLine("Los números múltiplos de 3 en el vector son:");
        foreach (int num in vector)
        {
            if (num % 3 == 0) // Comprobar si el número es múltiplo de 3
            {
                Console.WriteLine(num); // Mostrar el número múltiplo de 3
            }
        }
    }
}
