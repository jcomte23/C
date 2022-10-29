using System;

namespace SwitchCaseCore3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EJERCICIO AGENCIA");
            Console.WriteLine("Tabla de destinos\nelige uno de ellos:");
            Console.WriteLine("Bucaramanga\nCali\nbogota");
            Console.WriteLine(" ");
            string city = Console.ReadLine();
            city = city.ToLower();

            static void calcularPasaje(int pasaje)
            {
                double iva = pasaje * 0.19;
                double tasa_aeropuertaria = pasaje * 0.02;
                Console.WriteLine(" ");
                Console.WriteLine("PASAJE= $" + pasaje);
                Console.WriteLine("IVA= $" + iva);
                Console.WriteLine("TASA AEROPUERTARIA= $" + tasa_aeropuertaria);
                Console.WriteLine("COSTO TOTAL= $" + (pasaje + iva + tasa_aeropuertaria));
            }

            switch (city)
            {
                case "bucaramanga":
                    calcularPasaje(250000);
                    break;
                case "cali":
                    calcularPasaje(150000);
                    break;
                case "bogota":
                    calcularPasaje(145000);
                    break;
                default:
                    Console.WriteLine("elige 1 de las 3 ciudades");
                    break;
            }
            Console.WriteLine("see you soon, bye");

            Console.ReadKey();

        }
    }
}

