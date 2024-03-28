using System;
using System.IO;

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
            // Crear un StreamWriter para escribir en el archivo de salida
            using (StreamWriter writer = new StreamWriter(rutaArchivoSalida))
            {
                // Leer cada línea del archivo de entrada y procesarla
                using (StreamReader reader = new StreamReader(rutaArchivoEntrada))
                {
                    string linea;
                    int numeroLinea = 1;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        // Obtener los números de la línea
                        string[] numeros = linea.Split(' ');
                        foreach (string numero in numeros)
                        {
                            if (int.TryParse(numero, out int num))
                            {
                                if (EsPar(num))
                                {
                                    // Escribir el número par junto con la línea a la que pertenece en el archivo de salida
                                    writer.WriteLine($"En la línea {numeroLinea} el número {num} es par.");
                                }
                                else
                                {
                                    // Escribir el número impar junto con la línea a la que pertenece en el archivo de salida
                                    writer.WriteLine($"En la línea {numeroLinea} el número {num} es impar.");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"El valor '{numero}' en la línea {numeroLinea} no es un número válido y será ignorado.");
                            }
                        }
                        numeroLinea++;
                    }
                }
            }

            Console.WriteLine($"Se han procesado las líneas del archivo de entrada y los resultados han sido guardados en '{rutaArchivoSalida}'");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocurrió un error: {ex.Message}");
        }
    }

    static bool EsPar(int numero)
    {
        return numero % 2 == 0;
    }
}
