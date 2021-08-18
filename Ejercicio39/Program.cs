using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio39
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double celsius, resultadoConversion;
                Conversion opcion;
                Console.Clear();
                Console.WriteLine("Conversion de temperaturas Celsius");
                Console.Write("Ingrese la tenperatura en grados Celsius:");
                celsius = Convert.ToDouble(Console.ReadLine());
                if (celsius > 15)
                {
                    Console.WriteLine("1-Fharenheit");
                    Console.WriteLine("2-Reaumur");
                    Console.WriteLine("3-Kelvin");
                    Console.WriteLine("4-Rankine");
                    Console.Write("ingresa la opcion selecionada:");
                    opcion = (Conversion)Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case Conversion.Fahrenheit:
                            resultadoConversion = ConvertiraFahrenheit(celsius);
                            Console.WriteLine($"El equivalente en grados F es {resultadoConversion}");
                            break;
                        case Conversion.Reaumur:
                            resultadoConversion = ConvertiraReamur(celsius);
                            Console.WriteLine($"El equivalente en grados Reaumur es {resultadoConversion}");
                            break;
                        case Conversion.Kelvin:
                            resultadoConversion = ConvertiraKelvin(celsius);
                            Console.WriteLine($"El equivalente en grados K es {resultadoConversion}");
                            break;
                        case Conversion.Rankine:
                            resultadoConversion = ConvertiraRankine(celsius);
                            Console.WriteLine($"El equivalente en grados Rankine es {resultadoConversion}");
                            break;
                        default:
                            Console.WriteLine("Opcion ingresada no valida");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("la temperatura debe ser superior a los 15 grados");
                }
            }
            catch (FormatException)
            {

                Console.WriteLine("Numero mal ingresado");

            }
            catch (OverflowException)
            {
                Console.WriteLine("Numero demasiado grande... fin del programa");
            }
            Console.ReadLine();
        }

        private static double ConvertiraRankine(double celsius)
        {
            return celsius + 491.67;
        }

        private static double ConvertiraKelvin(double celsius)
        {
            return celsius + 273.15;
        }

        private static double ConvertiraReamur(double celsius)
        {
            return 0.8 * celsius;
        }

        private static double ConvertiraFahrenheit(double celsius)
        {
            return 1.8 * celsius + 32;
        }
    }
}
