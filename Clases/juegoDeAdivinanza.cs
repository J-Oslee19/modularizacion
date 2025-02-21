using System;

public class JuegoDeAdivinanza
{
    public static void IniciarJuego()
    {
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101);
        int intento;

        Console.WriteLine("He generado un número aleatorio entre 1 y 100. ¡Intenta adivinarlo!");

        do
        {
            Console.WriteLine("Ingrese su adivinanza:");
            if (!int.TryParse(Console.ReadLine(), out intento))
            {
                Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
                continue;
            }

            if (intento < numeroAleatorio)
            {
                Console.WriteLine("Demasiado bajo.");
            }
            else if (intento > numeroAleatorio)
            {
                Console.WriteLine("Demasiado alto.");
            }
            else
            {
                Console.WriteLine("¡Correcto! Has adivinado el número.");
            }
        } while (intento != numeroAleatorio);
    }
}