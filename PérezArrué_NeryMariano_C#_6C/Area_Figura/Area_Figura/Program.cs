using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Figura
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            double b, c,resultado, p= 3.1416;

            Console.WriteLine("----MENU PARA AREAS----");
            Console.WriteLine("1. Cuadrado");
            Console.WriteLine("2. Circulo");
            Console.WriteLine("Escoga una opcion"); 
            a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("Ingrese el lado del cuadrado: ");
                    b = Convert.ToDouble(Console.ReadLine());

                    resultado = Math.Pow(b, 2);
                    Console.WriteLine("El area del cuadrado es "+ resultado);

                    break;
                case 2:
                    Console.WriteLine("Ingrese el radio del circulo: ");
                    c = Convert.ToDouble(Console.ReadLine());

                    resultado = p * Math.Pow(c, 2);
                    Console.WriteLine("El area del cuadrado es " + resultado);

                    break;
                default:
                    Console.WriteLine("Opcion erronea");
                    break;

            }

            Console.ReadKey();


        }
    }
}
