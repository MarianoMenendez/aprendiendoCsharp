// See https://aka.ms/new-console-template for more information
using System;
using System.Timers;

namespace PrimeraAplicacion // 
{
    class Program // todo programa debe estar dentro de una clase, no pueden haber en un programa 2 clases con el mismo nombre a menos que esten en name spaces diferente
    {
        static void Main(string[] args)
        {
            int aleatory = aleatoryNumb();
            Console.WriteLine("Ingresa un número y te diremos si es menor o mayor al aleatorio");
            int userNumber = int.Parse(Console.ReadLine());
            while(userNumber != aleatory)
            {
                if(aleatory < userNumber)
                {
                    Console.WriteLine("el numero ingresado es mayor al aleatorio");
                    Console.WriteLine("Ingresa otro numero");
                    userNumber = int.Parse(Console.ReadLine());
                } 
                else if (aleatory > userNumber)
                {
                    Console.WriteLine("el numero ingresado es menor al aleatorio");
                    Console.WriteLine("Ingresa otro numero");
                    userNumber = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("felicidades el numero ingresado es el correcto");
        }
        
        static int aleatoryNumb()
        {
            Random num = new Random();
            return num.Next(0, 100);
        }
    }
}

//clases predefinidas - Biblioteca de clases
    //System es una clase predefinida
    /* Tambien se podría escribir asi
     * System.Console.WriteLine("Hola Mundo");
     */