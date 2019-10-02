using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablas
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Tabla del " + i);
                //Al momento de agregar un for dentro de otro,te permite combinar sus variables 

                for (int e = 1; e <= 10; e++)
                {
                    res = i * e;
                    Console.WriteLine(i + " x " + e + " = " + res);
                }

                Console.WriteLine(" ");
            }

            Console.ReadKey();
        }
    }
}
