using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cubo_de_un_numero
{
    class Program
    {
        static void Main(string[] args)
        {

            double numero;
            double cubo;


            Console.WriteLine("El cubo de un numero. ");
            Console.WriteLine(" ");
            Console.WriteLine("Escribe el numero: ");
            numero = Convert.ToDouble(Console.ReadLine());


            cubo  = numero * numero * numero;


            Console.WriteLine("Este es el cubo del numero: " + cubo);


            Console.ReadKey();


        }
    }
}
