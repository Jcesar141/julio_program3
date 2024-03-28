using System;
using System.Linq;

class Program
{
    // Ejercicio 1: Serie1
    static int Serie1(int n)
    {
        return (int)Math.Pow(2, n) - 1;
    }

    // Ejercicio 2: SumaSerie2
    static int SumaSerie2(int n)
    {
        int suma = 0;
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0)
                suma += i + 1;
        }
        return suma;
    }

    // Ejercicio 3: CantPal
    static int CantPal(string cadena)
    {
        return cadena.Split(' ').Count();
    }

    // Ejercicio 4: EliminarVoc
    static string EliminarVoc(string cadena)
    {
        string vocales = "aeiouAEIOU";
        return new string(cadena.Where(c => !vocales.Contains(c)).ToArray());
    }

    // Ejercicio 5: CadenaMasLarga
    static string CadenaMasLarga(string cadena)
    {
        return cadena.Split(' ').OrderByDescending(x => x.Length).FirstOrDefault();
    }

    // Ejercicio 6: EliminaPrim
    static string EliminaPrim(string cadena)
    {
        string[] palabras = cadena.Split(' ');
        for (int i = 0; i < palabras.Length; i++)
        {
            palabras[i] = palabras[i].Substring(1);
        }
        return string.Join(" ", palabras);
    }

    // Ejercicio 7: InvertirPal
    static string InvertirPal(string cadena)
    {
        string[] palabras = cadena.Split(' ');
        for (int i = 0; i < palabras.Length; i++)
        {
            char[] letras = palabras[i].ToCharArray();
            Array.Reverse(letras);
            palabras[i] = new string(letras);
        }
        return string.Join(" ", palabras);
    }

    // Ejercicio 8: ContarPares
    static int ContarPares(int[] numeros)
    {
        int count = 0;
        foreach (int num in numeros)
        {
            if (num % 2 == 0)
                count++;
        }
        return count;
    }

    static void Main(string[] args)
    {
        // Ejecutar Ejercicio 1: Serie1
        int nSerie = 6;
        int resultadoSerie1 = Serie1(nSerie);
        Console.WriteLine($"El término {nSerie}-ésimo de la serie es: {resultadoSerie1}");

        // Ejecutar Ejercicio 2: SumaSerie2
        int nSuma = 6;
        int resultadoSuma = SumaSerie2(nSuma);
        Console.WriteLine($"La suma de los {nSuma} términos pares de la serie es: {resultadoSuma}");

        // Ejecutar Ejercicio 3: CantPal
        string cadena = "Esta es una prueba mas";
        Console.WriteLine($"Cantidad de palabras en la cadena: {CantPal(cadena)}");

        // Ejecutar Ejercicio 4: EliminarVoc
        Console.WriteLine($"Cadena sin vocales: {EliminarVoc(cadena)}");

        // Ejecutar Ejercicio 5: CadenaMasLarga
        Console.WriteLine($"Palabra más larga de la cadena: {CadenaMasLarga(cadena)}");

        // Ejecutar Ejercicio 6: EliminaPrim
        Console.WriteLine($"Cadena con primera letra de cada palabra eliminada: {EliminaPrim(cadena)}");

        // Ejecutar Ejercicio 7: InvertirPal
        Console.WriteLine($"Cada palabra de la cadena invertida: {InvertirPal(cadena)}");

        // Ejecutar Ejercicio 8: ContarPares
        int[] v = { 2, 4, 5, 12, 23, 54, 3, 34, 6 };
        int cantidadPares = ContarPares(v);
        Console.WriteLine($"Cantidad de números pares en el arreglo: {cantidadPares}");
    }
}
