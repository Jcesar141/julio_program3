using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Ruta del archivo de entrada
        string rutaArchivoEntrada = "archivo_entrada.txt";

        // Ruta del archivo de salida
        string rutaArchivoSalida = "archivo_salida.txt";

        try
        {
            // Leer todas las líneas del archivo de entrada
            string[] lineas = File.ReadAllLines(rutaArchivoEntrada);

            // Crear un arreglo para almacenar el conteo de vocales por línea
            int[] conteoVocalesPorLinea = new int[lineas.Length];

            // Contar las vocales por línea
            for (int i = 0; i < lineas.Length; i++)
            {
                conteoVocalesPorLinea[i] = ContarVocales(lineas[i]);
            }

            // Escribir los resultados en el archivo de salida
            using (StreamWriter writer = new StreamWriter(rutaArchivoSalida))
            {
                for (int i = 0; i < lineas.Length; i++)
                {
                    writer.WriteLine($"Línea {i + 1}: {conteoVocalesPorLinea[i]} vocales");
                }
            }

            Console.WriteLine("Conteo de vocales por línea completado. Resultados guardados en 'salida.txt'");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocurrió un error: {ex.Message}");
        }
    }

    static int ContarVocales(string texto)
    {
        // Utilizar una expresión regular para contar las vocales
        MatchCollection matches = Regex.Matches(texto, @"[aeiouAEIOU]");
        return matches.Count;
    }
}
