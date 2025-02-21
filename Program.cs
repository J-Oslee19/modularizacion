using System;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Calculadora basica");
            Console.WriteLine("2. Validación de contraseña");
            Console.WriteLine("3. Numeros primos");
            Console.WriteLine("4. Suma de números pares");
            Console.WriteLine("5. Conversión de temperatura");
            Console.WriteLine("6. Contador de vocales");
            Console.WriteLine("7. Calculo de factorial");
            Console.WriteLine("8. Juego de adivinanza");
            Console.WriteLine("9. Paso por referencia");  
            Console.WriteLine("10. Tabla de multiplicar");  
            Console.WriteLine("0. Salir");

            string opcion = Console.ReadLine();

            if (opcion == "0")
            {
                break;
            }

            switch (opcion)
            {
                case "1":
                Calculadora.CalculadoraBasica();
                    break;
    
                case "2":
                ValidacionDeContrasenia.PedirContrasenia();
                    break;

                case "3":
                NumerosPrimos.EsPrimo();
                    break;

                case "4":
                SumaDeNumerosPares.CalcularSumaDePares();
                    break;

                case "5":
                ConversionDeTemperatura.ConvertirTemperatura();
                    break;

                case "6":
                ContadorDeVocales.ContarVocales();
                    break;

                case "7":
                CalculoDeFactorial.CalcularFactorial();
                    break;

                case "8":
                JuegoDeAdivinanza.IniciarJuego();
                    break;

                case "9":
                Intercambio.EjecutarIntercambio();
                    break;

                case "10":
                TablaDeMultiplicar.GenerarYMostrarTabla();
                    break;
                    
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }

}

