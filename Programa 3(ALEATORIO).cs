using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMA3
{
    class Program
    {
            //SUMA DE NUMEROS ALEATORIOS

static public float numero1 = 24.5F;
        static void Main(String[] args)
        {
            //Hacemos la declaracion dentro de un metodo
            float numero2 = 0.0F;
            //Aqui es donde se le asigna un valor aleatorio
            Random numAleatorio = new Random ();
            numero2 = (float)numAleatorio.Next(1, 11);
            Console.WriteLine(string.Format(
            "El resultdo de la suma de {0} y {1} es {2}",
            numero1, numero2, numero1 + numero2));
            Console.ReadLine();
        }
    }
}
