using System;

public class SumaDeNumerosPares
{
    public static void CalcularSumaDePares()
    {
        int suma = 0;
        int numero;

        Console.WriteLine("Ingrese números enteros (ingrese 0 para terminar):");

        while (true)
        {
            if (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero:");
                continue;
            }

            if (numero == 0)
            {
                break;
            }

            if (numero % 2 == 0)
            {
                suma += numero;
            }
        }

        Console.WriteLine($"La suma de todos los números pares ingresados es: {suma}");
    }
}