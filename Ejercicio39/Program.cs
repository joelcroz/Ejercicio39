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
                double celsius, conversion;
                int opcion;
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
                    opcion = Convert.ToInt32(Console.ReadLine());
                    if (opcion >= 1 && opcion <= 4)
                    {
                        switch (opcion)
                        {
                            case 1:
                                conversion = ConvertiraFahrenheit(celsius);
                                Console.WriteLine($"La conversion a Fah es {conversion}");
                                break;
                            case 2:
                                conversion = ConvertiraReamur(celsius);
                                Console.WriteLine($"La conversion a Reamur es {conversion}");
                                break;
                            case 3:
                                conversion = ConvertiraKelvin(celsius);
                                Console.WriteLine($"La conversion a Kelvin es {conversion}");
                                break;
                            default:
                                conversion = ConvertiraRankine(celsius);
                                Console.WriteLine($"La conversion a Rankine es {conversion}");
                                break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Opcion no valida");
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
