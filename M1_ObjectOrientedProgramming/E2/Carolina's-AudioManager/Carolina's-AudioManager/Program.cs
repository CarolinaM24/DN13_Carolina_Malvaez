using L_AudioManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Carolina_s_AudioManager
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeticion = 0;

            while (repeticion < 10)
            {
                Console.WriteLine("Escribe el tipo de transporte: ");

                string vehiculoType = Console.ReadLine().ToLower();

                vehiculo vehiculo = null;

                switch (vehiculoType)
                {
                    case "tren":
                        vehiculo = new tren();
                        break;
                    case "camion":
                        vehiculo = new camion();
                        break;
                    case "automovil":
                        vehiculo = new automovil();
                        break;
                   
                    default:
                        Console.WriteLine("El transporte no existe");
                        System.Threading.Thread.Sleep(2000);
                        break;
                }

                if (vehiculo != null)
                {
                    vehiculo.VehiculoSound();
                }
                repeticion++;
            }

        }
    }
}
