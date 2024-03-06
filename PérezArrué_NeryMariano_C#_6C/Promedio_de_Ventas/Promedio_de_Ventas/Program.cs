using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio_de_Ventas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Ingrese el nombre del vendedor: ");
            string nombreVendedor = Console.ReadLine();

            double sumaVentas = 0;
            int meses = 0;

            while (true)
            {
                Console.Write($"Ingrese las ventas del mes {meses + 1} (ingrese '-1' para finalizar): ");
                string input = Console.ReadLine();

                if (input == "-1")
                    break;


                if (double.TryParse(input, out double ventasMes))
                {

                    sumaVentas += ventasMes;
                    meses++;
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                }
            }

            double promedioVentas = meses > 0 ? sumaVentas / meses : 0;

            Console.WriteLine($"\nResumen de ventas para: {nombreVendedor}");
            Console.WriteLine($"Total de meses: {meses}");
            Console.WriteLine($"Total de ventas: {sumaVentas:C}");
            Console.WriteLine($"Promedio de ventas por mes: {promedioVentas:C}");

            Console.ReadLine();
        }
    }
}
