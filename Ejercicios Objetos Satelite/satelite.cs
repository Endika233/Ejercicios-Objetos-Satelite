using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Objetos_Satelite
{
        public class Satelite
        {
            private double meridiano;
            private double paralelo;
            private double distancia_tierra;

            public Satelite(double m, double p, double d)
            {
                meridiano = m;
                paralelo = p;
                distancia_tierra = d;
            }

            public Satelite()//Constructor vacio
            {
                meridiano = paralelo = distancia_tierra = 0;
            }

            public void SetPosicion(double m, double p, double d)
            {
                meridiano = m;
                paralelo = p;
                distancia_tierra = d;
            }

            public void PrintPosicion()
            {
                Console.WriteLine("El satélite se encuentra en el paralelo " + paralelo +
                "Meridiano"+meridiano+" a una distancia de la tierra de "+distancia_tierra+
                "Kilómetros");
                Console.ReadLine();
            }
            public void VariaAltura(double desplazamiento)
            {
                distancia_tierra = distancia_tierra + desplazamiento;
            }
            public bool EnOrbita()
            {
                bool orbita=false;
                if (distancia_tierra>0)
                {
                    orbita=true;
                }
                return orbita;
            }
            public void VariaPosicion(double variap,double variam)
            {
                paralelo = paralelo + variap;
                meridiano = meridiano + variam;
            }
        }
    }

//Modifica la clase satélite y añádele los siguientes métodos:
//Método void VariaAltura(double desplazamiento): Este método acepta un parámetro que será positivo o negativo dependiendo de si el satélite tiene que alejarse o acercarse a La Tierra.
//Método boolean EnOrbita() : Este método devolverá false si el satélite está en tierra, y true en caso contrario.
// Método void VariaPosicion(double variap, double variam): Este método permite modificar los atributos de 
//posición(meridiano y paralelo) mediante los parámetros variap y variam.Estos parámetros serán valores positivos o negativos 
//relativos que harán al satélite modificar su posición.
