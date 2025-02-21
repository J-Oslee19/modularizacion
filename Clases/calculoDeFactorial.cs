using System;

public class CalculoDeFactorial
{
    public static void CalcularFactorial()
    {
        Console.WriteLine("Ingrese un número entero:");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            if (numero < 0)
            {
                Console.WriteLine("El factorial no está definido para números negativos.");
            }
            else
            {
                long factorial = CalcularFactorialDeNumero(numero);
                Console.WriteLine($"El factorial de {numero} es {factorial}.");
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
        }
    }

    private static long CalcularFactorialDeNumero(int numero)
    {
        long resultado = 1;
        for (int i = 1; i <= numero; i++)
        {
            resultado *= i;
        }
        return resultado;
    }
}