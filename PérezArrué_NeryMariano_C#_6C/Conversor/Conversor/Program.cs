using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Ingrese la cantidad en kilómetros: ");
            if (double.TryParse(Console.ReadLine(), out double cantidadKilometros))
            {
                
                double cantidadMetros = cantidadKilometros * 1000;  
                double cantidadYardas = cantidadMetros * 1.09361;  
                double cantidadVaras = cantidadMetros * 1.1963; 

               
                Console.WriteLine($"\nResultados para {cantidadKilometros} kilómetros:");
                Console.WriteLine($"En metros: {cantidadMetros:N2} metros");
                Console.WriteLine($"En yardas: {cantidadYardas:N2} yardas");
                Console.WriteLine($"En varas: {cantidadVaras:N2} varas");
            }
            else
            {
                Console.WriteLine("Por favor, ingrese una cantidad válida en kilómetros.");
            }

            Console.ReadLine();
        }
    }
}
