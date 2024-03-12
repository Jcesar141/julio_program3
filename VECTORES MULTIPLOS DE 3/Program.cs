using System;

class Program
{
    static void Main(string[] args)
    {
        // Definir un vector de cinco dígitos
        int[] vector = { 1, 2, 3, 4, 5 };

        // Variable para contar cuántos números son múltiplos de 3
        int contadorMultiplosDe3 = 0;

        // Contar los números múltiplos de 3 en el vector
        foreach (int num in vector)
        {
            if (num % 3 == 0) // Comprobar si el número es múltiplo de 3
            {
                contadorMultiplosDe3++; // Incrementar el contador de múltiplos de 3
            }
        }

        // Mostrar el resultado
        Console.WriteLine("La cantidad de números múltiplos de 3 en el vector es: " + contadorMultiplosDe3);
    }
}
