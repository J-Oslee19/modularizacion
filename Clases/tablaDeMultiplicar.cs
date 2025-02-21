using System;

public class TablaDeMultiplicar
{
    public static void GenerarYMostrarTabla()
    {
        Console.WriteLine("Ingrese un número para mostrar su tabla de multiplicar del 1 al 10:");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            int[] tabla = GenerarTabla(numero);
            MostrarTabla(numero, tabla);
        }
        else
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
        }
    }

    private static int[] GenerarTabla(int numero)
    {
        int[] tabla = new int[10];
        for (int i = 0; i < 10; i++)
        {
            tabla[i] = numero * (i + 1);
        }
        return tabla;
    }

    private static void MostrarTabla(int numero, int[] tabla)
    {
        Console.WriteLine($"Tabla de multiplicar del {numero}:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{numero} x {i + 1} = {tabla[i]}");
        }
    }
}