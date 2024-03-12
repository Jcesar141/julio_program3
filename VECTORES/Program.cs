using System;

class Program
{
    static void Main(string[] args)
    {
        // Definir un vector de cinco dígitos
        int[] vector = { 1, 2, 3, 4, 5 };

        // Variables para almacenar la suma de números pares e impares
        int sumaPares = 0;
        int sumaImpares = 0;

        // Sumar los números pares e impares del vector
        foreach (int num in vector)
        {
            if (num % 2 == 0) // Comprobar si el número es par
            {
                sumaPares += num; // Sumar al total de números pares
            }
            else // Si el número es impar
            {
                sumaImpares += num; // Sumar al total de números impares
            }
        }

        // Mostrar los resultados
        Console.WriteLine("La suma de los números pares en el vector es: " + sumaPares);
        Console.WriteLine("La suma de los números impares en el vector es: " + sumaImpares);
    }
}

