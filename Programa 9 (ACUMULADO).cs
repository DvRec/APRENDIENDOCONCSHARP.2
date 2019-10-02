using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMA_9
{
    class Program
    {
        static void Main(string[] args)
        {
            string _numero;
            int numero;
            int acumulado = 0;
            Console.WriteLine("capture los enteros que desea acumular");
            Console.WriteLine("Dejar vacio y dar intro para poder salir");
            Console.WriteLine("");
            //El ciclo concluirá hasta que se ejecute de forma explicita
            while (true)
            {
                Console.WriteLine("Dame un numero que sea ENTERO");
                _numero = Console.ReadLine();
                if (_numero == "")
                {
                    break;
                }
                else
                {
                    if (int.TryParse(_numero, out numero))
                    {
                        acumulado += numero;
                        Console.WriteLine(String.Format("El monto acumulado es {0}", acumulado));
                    }
                    else
                    {
                        Console.WriteLine("El dato que ingresaste no es un numero entero");
                        Console.WriteLine("Vuelve a intentarlo");

                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Presiona INTRO para continuar");
            Console.ReadKey();
        }
    }
}
