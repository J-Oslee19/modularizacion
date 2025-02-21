using System;

public class Calculadora
{
    public static void CalculadoraBasica()
    {
        double numero1, numero2;
        string operacion;

        Console.WriteLine("Ingrese el primer número:");
        while (!double.TryParse(Console.ReadLine(), out numero1))
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido:");
        }

        Console.WriteLine("Ingrese el segundo número:");
        while (!double.TryParse(Console.ReadLine(), out numero2))
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido:");
        }

        Console.WriteLine("\n--Seleccione una operación:--");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");                 
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");

        operacion = Console.ReadLine();

        switch (operacion)
        {
            case "1":
                Console.WriteLine($"Resultado: {Suma(numero1, numero2)}");
                break;
            case "2":
                Console.WriteLine($"Resultado: {Resta(numero1, numero2)}");
                break;
            case "3":
                Console.WriteLine($"Resultado: {Multiplicacion(numero1, numero2)}");
                break;
            case "4":
                if (numero2 != 0)
                {
                    Console.WriteLine($"Resultado: {Division(numero1, numero2)}");
                }
                else
                {
                    Console.WriteLine("Error: No se puede dividir por cero.");
                }
                break;
            default:
                Console.WriteLine("Operación no válida.");
                break;
        }
    }

    public static double Suma(double a, double b)
    {
        return a + b;
    }

    public static double Resta(double a, double b)
    {
        return a - b;
    }

    public static double Multiplicacion(double a, double b)
    {
        return a * b;
    }

    public static double Division(double a, double b)
    {
        return a / b;
    }
}