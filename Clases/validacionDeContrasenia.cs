using System;

public class ValidacionDeContrasenia
{
    public static void PedirContrasenia()
    {
        string contraseniaCorrecta = "oslee19";
        string contraseniaIngresada;

        do
        {
            Console.WriteLine("Por favor, ingrese la contraseña:");
            contraseniaIngresada = Console.ReadLine();

            if (contraseniaIngresada == contraseniaCorrecta)
            {
                Console.WriteLine("Acceso concedido.");
                break;
            }
            else
            {
                Console.WriteLine("Contraseña incorrecta. Inténtelo de nuevo.");
            }
        } while (contraseniaIngresada != contraseniaCorrecta);
    }
}