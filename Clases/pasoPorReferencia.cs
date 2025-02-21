using System;

public class Intercambio
{
    public static void Intercambiar(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    public static void EjecutarIntercambio()
    {
        Console.WriteLine("Ingrese el primer número:");
        if (!int.TryParse(Console.ReadLine(), out int numero1))
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
            return;
        }

        Console.WriteLine("Ingrese el segundo número:");
        if (!int.TryParse(Console.ReadLine(), out int numero2))
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
            return;
        }

        Console.WriteLine($"Valores originales: Numero1 = {numero1}, Numero2 = {numero2}");

        Intercambiar(ref numero1, ref numero2);

        Console.WriteLine($"Valores intercambiados: Numero1 = {numero1}, Numero2 = {numero2}");
    }
}