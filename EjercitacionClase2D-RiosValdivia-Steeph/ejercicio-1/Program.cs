using System;

namespace ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int numeroMaximo = int.MaxValue;
            int numeroMinimo = int.MinValue;
            int sumaNumIngresados = 0;
            int promNumIngresados = 0;
            bool validar = true;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese 5 numeros: ");
                do
                {

                    validar = int.TryParse(Console.ReadLine(), out numeroIngresado);

                } while (!validar);

                if (i is 0)
                {
                    numeroMaximo = numeroIngresado;
                    numeroMinimo = numeroIngresado;
                }

                if (numeroIngresado > numeroMaximo)
                {
                    numeroMaximo = numeroIngresado;
                }
                
                if( numeroIngresado < numeroMinimo)
                {
                    numeroMinimo = numeroIngresado;
                }

                sumaNumIngresados += numeroIngresado;
            }

            promNumIngresados = sumaNumIngresados / 5;

            Console.WriteLine($"El numero maximo ingresado es: {numeroMaximo}. \n" +
                $"El numero minimo ingresado es: { numeroMinimo}. \n" +
                $"El promedio de los numeros ingresados es: { promNumIngresados}.");

            Console.ReadKey();
        
        }
    }
}
