using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compara
{
    class Program
    {
        static void Main(string[] args)
        {
            // Primeramente van los datos que vamos a necesitar
            // int es para numeros enteros
            // string para hacer una cadena 

            string _num1 = "", _num2 = "";
            int num1 = 0, num2 = 0;

            Console.Write("num1 :");
            _num1 = Console.ReadLine();

            Console.Write("num2 : ");
            _num2 = Console.ReadLine();

            num1 = Convert.ToInt32(_num1);
            num2 = Convert.ToInt32(_num2);


            if (num1 == num2)
                // if se utiliza para hablar sobre situaciones si es real o es falso 
                Console.WriteLine(
                    String.Format(
                        "NUMEROS PROPORCIONADOS {0} y {1} {2}",
                        num1, num2, "LOS NUMEROS SON IGUALES"));


            else
            // else va con el if cuando es una estructura de control
            if (num1 > num2)


                Console.WriteLine(
                    String.Format("NUMEROS PROPORCIONADOS {0} y {1} {2}",
                    num1, num2, "EL MAYOR ES EL SEGUNDO "));
            // para que demos finalidad al programa

            Console.WriteLine("");
            Console.WriteLine("DARLE ENTER PARA CONTINUAR");
            Console.ReadKey();
        }
    }
}
