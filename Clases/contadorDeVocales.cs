using System;

public class ContadorDeVocales
{
    public static void ContarVocales()
    {
        Console.WriteLine("Ingrese una frase:");
        string frase = Console.ReadLine();
        int numeroDeVocales = ContarVocalesEnCadena(frase);
        Console.WriteLine($"La frase contiene {numeroDeVocales} vocales.");
    }

    private static int ContarVocalesEnCadena(string cadena)
    {
        int contador = 0;
        string vocales = "aeiouAEIOU";

        foreach (char c in cadena)
        {
            if (vocales.Contains(c))
            {
                contador++;
            }
        }

        return contador;
    }
}