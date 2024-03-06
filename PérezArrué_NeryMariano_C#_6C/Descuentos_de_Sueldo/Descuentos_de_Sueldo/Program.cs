using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descuentos_de_Sueldo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Ingrese el sueldo base del empleado: ");
            if (double.TryParse(Console.ReadLine(), out double sueldoBase))
            {
                
                double renta = sueldoBase * 0.10;
                double afp = sueldoBase * 0.07;
                double seguroSocial = sueldoBase * 0.05;

                
                double sueldoNeto = sueldoBase - renta - afp - seguroSocial;

                
                Console.WriteLine("\nResumen de sueldo del empleado");
                Console.WriteLine($"Sueldo base: {sueldoBase:C}");
                Console.WriteLine($"Descuento por Renta (10%): {renta:C}");
                Console.WriteLine($"Descuento por AFP (7%): {afp:C}");
                Console.WriteLine($"Descuento por Seguro Social (5%): {seguroSocial:C}");
                Console.WriteLine($"Sueldo neto a pagar: {sueldoNeto:C}");
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un sueldo base válido.");
            }

            Console.ReadLine();
        }
    }
}

