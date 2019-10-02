using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se declara la variable con el valor asignado
            string numero = "1234";
            //Se muestra la el tipo de dato de la varible
            Console.WriteLine(numero.GetType().ToString());
            //Se realiza la conversion del tipo de dato String a int
            int intNumero = Convert.ToInt32(numero);
            //Se muestra el tipo de dato de la varible para mostrar el cambio
            Console.WriteLine(intNumero.GetType().ToString());
            //Se imprime la nueva variable
            Console.WriteLine(String.Format("El número es {0}", intNumero));
            Console.ReadLine();
        }
    }
}
