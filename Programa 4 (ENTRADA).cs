using System;

namespace Entrada
{
    class Program
    {
        static void Main(string[] args)
        {
            //Primero declaramos la variable que vamos a usar
            string valor;
            //Ahora nos piden la variable
            Console.Write("\n\n\tEscribe algo: ");
            //Luego se lee y se uarda la variable
            valor = Console.ReadLine();
            //Se hace un try catch que es mas facil de usar y con menos problemas que con el if else
            try
            {
                int x = int.Parse(valor);
                Console.WriteLine("\n\tDato entero {0} es correcto.", valor);
            }
            catch
            {
                Console.WriteLine("\n\tDato no es entero. Intentar de nuevo.");
            }
            //Y finalmente se acaba el programa
            Console.WriteLine("\n\tPresiona enter para continuar....");
            //Se hace un ReadKey ya que sin el no se veria el programa solo correria sin pausarse
            Console.ReadKey();
        }
    }
}
