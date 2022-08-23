using System;

namespace ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            string opcion = "salir";
            bool validar;

            do
            {
                Console.WriteLine("Ingrese un numero o ingrese 'salir': ");
                do
                {
                    validar = int.TryParse(Console.ReadLine(), out numeroIngresado);

                    if(validar is false)
                    {
                        Console.WriteLine("Numero invalido, Reingrese numero: ");
                    }
                } while (!validar);
                /*
                validar = int.TryParse(Console.ReadLine(), out numeroIngresado);
                while (!validar)
                {
                    Console.WriteLine("Numero invalido, Reningrese numero: ");
                    validar = int.TryParse(Console.ReadLine(), out numeroIngresado);
                } */
                esNumPrimo(numeroIngresado);
                Console.WriteLine("Ingrese un numero o de lo contrario ingrese 'salir': ");
                opcion = Console.ReadLine();
            }while (opcion != "salir");
        }

        static void esNumPrimo(int num)
        {
            bool todoOk = true;

            for (int i = 2; i <= num; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        todoOk = false;
                        break;
                    }
                }
                if (todoOk)
                {
                    Console.WriteLine($"El numero {i} es primo!");
                }
                todoOk = true;
            }
        }
    }
}
