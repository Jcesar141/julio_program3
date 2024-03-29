using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        // Ruta del archivo de entrada
        string rutaArchivoEntrada = "entrada.txt";

        // Ruta del archivo de salida
        string rutaArchivoSalida = "salida.txt";

        try
        {
            // Crear un StreamWriter para escribir en el archivo de salida
            using (StreamWriter writer = new StreamWriter(rutaArchivoSalida))
            {
                // Leer cada línea del archivo de entrada y procesarla
                using (StreamReader reader = new StreamReader(rutaArchivoEntrada))
                {
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        // Encontrar el menor de los dígitos en la línea actual
                        int menorDigito = EncontrarMenorDigito(linea);

                        // Escribir el resultado en el archivo de salida
                        writer.WriteLine($"D=> {linea} ; R=> {menorDigito}");
                    }
                }
            }

            Console.WriteLine($"Se han procesado los números del archivo de entrada y los resultados han sido guardados en '{rutaArchivoSalida}'");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocurrió un error: {ex.Message}");
        }
    }

    static int EncontrarMenorDigito(string numero)
    {
        // Convertir el número en una secuencia de caracteres y ordenarla
        var digitosOrdenados = numero.Where(char.IsDigit).OrderBy(c => c);

        // El menor dígito será el primer carácter de la secuencia
        return digitosOrdenados.First() - '0'; // Restamos '0' para convertir el carácter en el valor numérico correspondiente
    }
}
