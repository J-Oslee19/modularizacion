using System;

public class NumerosPrimos
{
    public static void EsPrimo()
    {
        int numero;
        Console.WriteLine("Por favor, ingrese un número:");
        if (!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.WriteLine("Entrada no válida.");
            return;
        }

        if (numero <= 1)
        {
            Console.WriteLine($"El número {numero} no es primo.");
            return;
        }

        if (numero == 2)
        {
            Console.WriteLine($"El número {numero} es primo.");
            return;
        }

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
            {
                Console.WriteLine($"El número {numero} no es primo.");
                return;
            }
        }

        Console.WriteLine($"El número {numero} es primo.");
    }
}