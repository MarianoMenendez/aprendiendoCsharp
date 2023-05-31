// See https://aka.ms/new-console-template for more information
using System;

namespace PrimeraAplicacion // 
{
    class Program // todo programa debe estar dentro de una clase, no pueden haber en un programa 2 clases con el mismo nombre a menos que esten en name spaces diferente
    {
        static void Main(string[] args)
        {
            function();
            Console.WriteLine("Ingrese el primer número");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            int num2 = int.Parse(Console.ReadLine());
            validacion(num1, num2)
            ;
        }
        static void function()
        {
            Console.WriteLine("holis");
        }

        static int sumaNumeros(int num1, int num2)
        {
            int suma = num1 + num2;
            return suma;
        }

        static void validacion(int num1, int num2)
        {
            Console.WriteLine($"Está seguro que los números deben ser {num1} y {num2}?");
            if (Console.ReadLine() == "si")
            {
                int resultado = sumaNumeros(num1, num2);
                Console.WriteLine($"El resultado de la suma es {resultado}");
            }
            else
            {
                Console.WriteLine("qué numero desea modificar");
                if (Console.ReadLine() == "1")
                {
                    Console.WriteLine("Ingrese el valor del primer número");
                    num1 = int.Parse(Console.ReadLine());
                } else
                {
                    Console.WriteLine("Ingrese el valor del primer número");
                    num2 = int.Parse(Console.ReadLine());
                }
                validacion(num1, num2);
            }
        }
    }
}

//clases predefinidas - Biblioteca de clases
    //System es una clase predefinida
    /* Tambien se podría escribir asi
     * System.Console.WriteLine("Hola Mundo");
     */