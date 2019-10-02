using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMA10
{
    class Program
    {
        static void Main(string[] args)
        {
            string _numero;
            int numero;
            bool esMultiplo3, esMultiplo5, esMultiplo7;

            try
            {
                Console.WriteLine("Dame un numero que sea entero:");
                _numero = Console.ReadLine();
                numero = Convert.ToInt32(_numero);
                // Cuando el numero tenga un residual a 0con
                //respecto a un numero, es que ese es su multiplo
                esMultiplo3 = ((numero % 3) == 0);
                esMultiplo5 = ((numero % 5) == 0);
                esMultiplo7 = ((numero % 7) == 0);
                //Cuando se es multiplo de 3 y 5 al mismo tiempo, o si es multiplo de 7
                if ((esMultiplo3 & esMultiplo5) | esMultiplo7)
                {
                    Console.WriteLine("Es correcto!");
                }
                else
                {
                    Console.WriteLine("Es incorrecto :(");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("El dato que nos haz proporcionado provoca errores");
                Console.WriteLine(e.Message);

            }
            finally
            {
                Console.WriteLine("");
                Console.WriteLine("Presiona INTRO para poder continua!");
                Console.ReadKey();

            }
        }
    }
}



