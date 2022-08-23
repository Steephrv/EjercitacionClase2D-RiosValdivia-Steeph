using System;

namespace ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            bool validar;

            Console.WriteLine("Ingrese un numero: ");

            do
            {
                validar = int.TryParse(Console.ReadLine(), out numeroIngresado);
            } while (!validar);

            if(numeroIngresado > 0 )
            {
                Console.WriteLine($"El cuadrado del numero ingresado es: {Math.Pow(numeroIngresado,2)}.\n" +
                    $"El cubo del numero ingresado es: {Math.Pow(numeroIngresado,3)}.");

            }
            else
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
            }

            Console.ReadKey();      
        }
    }
}
