using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjericioInterfaces
{
   
    
        public interface Operaciones
        {
            double CalcularArea(double num1);
            double CalcularLongitud(double num1, double num2);
            double CalcularVolumen(double num1);
        }

       
        public class OperacionesMatematicas : Operaciones
        {
            public double CalcularArea(double num1)
            {
                return num1 * num1; 
            }

            public double CalcularLongitud(double num1, double num2)
            {
                return 2 * Math.PI * num1 * num2; 
            }

            public double CalcularVolumen(double num1)
            {
                return Math.PI * Math.Pow(num1, 2);
            }

            public void Imprimir(double area, double longitud, double volumen)
            {
                Console.WriteLine("Área: " + area);
                Console.WriteLine("Longitud: " + longitud);
                Console.WriteLine("Volumen: " + volumen);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                OperacionesMatematicas operaciones = new OperacionesMatematicas();

                Console.Write("Ingresa el valor del radio: ");
                double radio = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingresa el valor de la altura: ");
                double altura = Convert.ToDouble(Console.ReadLine());

                double area = operaciones.CalcularArea(radio);
                double longitud = operaciones.CalcularLongitud(radio, altura);
                double volumen = operaciones.CalcularVolumen(radio);

                operaciones.Imprimir(area, longitud, volumen);

                Console.ReadKey();
            }
        }
    }


