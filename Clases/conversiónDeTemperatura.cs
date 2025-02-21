using System;

public class ConversionDeTemperatura
{
    public static void ConvertirTemperatura()
    {
        Console.WriteLine("Seleccione una opción:");
        Console.WriteLine("1. Convertir de Celsius a Fahrenheit");
        Console.WriteLine("2. Convertir de Fahrenheit a Celsius");

        string opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                ConvertirCelsiusAFahrenheit();
                break;
            case "2":
                ConvertirFahrenheitACelsius();
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }

    private static void ConvertirCelsiusAFahrenheit()
    {
        Console.WriteLine("Ingrese la temperatura en grados Celsius:");
        if (double.TryParse(Console.ReadLine(), out double celsius))
        {
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius} grados Celsius son {fahrenheit} grados Fahrenheit.");
        }
        else
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
        }
    }

    private static void ConvertirFahrenheitACelsius()
    {
        Console.WriteLine("Ingrese la temperatura en grados Fahrenheit:");
        if (double.TryParse(Console.ReadLine(), out double fahrenheit))
        {
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"{fahrenheit} grados Fahrenheit son {celsius} grados Celsius.");
        }
        else
        {
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número.");
        }
    }
}