using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Objetos_Satelite
{
    class Program
    {
        static void Main(string[] args)
        {
            bool orbita;
            Satelite s1 = new Satelite(50,50,1000);
            s1.VariaAltura(-1000);
            s1.VariaPosicion(-10, 10);
            s1.PrintPosicion();
            orbita = s1.EnOrbita();
            if (orbita)
            {
                Console.WriteLine("Hasta el infinito y más allá");
            }
            else if (!orbita)
            {
                Console.WriteLine("Echa gasofa al cacharro");
            }

            Console.ReadKey();
        }
    }
}
