using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase04_CSharp
{
    class Program
    {
        static void Vectores()
        {
            int[] numeros = new int[4]; //definición explicita

            string[] nombres = { "hola", "isma", "papas" }; // definición implicita

            int contador = 0;
            int longitud = 0;

            // while (contador < longitud)
            //{
            //    Console.WriteLine($"la string en la posición {contador} es {nombres[contador]}");

            //    contador++;
            //}

            for (int i = 0; i < nombres.Length; i++)
            {

                Console.Write("Ingresa un nombre: ");
                nombres[i] = Console.ReadLine();

            }
            Console.WriteLine();
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"- {nombres[i]}");
            }

            Array.Sort(nombres);
        }

        public static int Sumar(int num, int num2)
        {

            int resultado = 0;
            resultado = num + num2;

            return resultado;
            
        }

        static void Main(string[] args)
        {

            int resultado2 = 0;
            // Vectores();

            Console.ForegroundColor = ConsoleColor.Yellow;
            resultado2 = Sumar(5, 5);

            Console.WriteLine();
            Console.WriteLine($"- {resultado2}");

           

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Presione cualquier tecla para salir...");

            Console.ReadKey();
        }
    }
}
