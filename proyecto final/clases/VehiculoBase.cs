using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final.clases
{
    internal class VehiculoBase
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public int Anio { get; set; }
        public string Placa { get; set; }
        public string Tipo { get; set; }
        public int VelocidadMaxima { get; set; }
        public int VelocidadActual { get; private set; }

        public void Bocina()
        {
            Console.WriteLine("¡BEET BEET!");
        }

        public void Acelerar(int cuanto)
        {
            if (VelocidadActual + cuanto <= VelocidadMaxima)
                VelocidadActual += cuanto;
            else
                Console.WriteLine("No se puede acelerar más allá de la velocidad máxima.");
        }

        public void Encender()
        {
            Console.WriteLine("El vehículo está encendido.");
        }

        public void Apagar()
        {
            Console.WriteLine("El vehículo está apagado.");
        }

        public void Frenar(int cuanto)
        {
            if (VelocidadActual - cuanto >= 0)
                VelocidadActual -= cuanto;
            else
                Console.WriteLine("El vehículo ya se encuentra detenido.");
        }
    }


}
