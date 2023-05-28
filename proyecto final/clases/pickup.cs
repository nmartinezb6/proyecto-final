using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final.clases
{
    internal class pickup
    {
        internal class PickUp : VehiculoBase
        {
            public string CapacidadCarga { get; set; }
            public bool DobleCabina { get; set; }

            public void ActivarTraccion4x4()
            {
                Console.WriteLine("Tracción 4x4 activada.");
            }
        }

        internal class Sedan : VehiculoBase
        {
            public int NumeroPuertas { get; set; }
            public bool TechoSolar { get; set; }

            public void AbrirTechoSolar()
            {
                Console.WriteLine("El techo solar se ha abierto.");
            }
        }

        internal class SUV : VehiculoBase
        {
            public bool TerceraFilaAsientos { get; set; }
            public int CapacidadMaletero { get; set; }

            public void DesplegarTerceraFila()
            {
                Console.WriteLine("La tercera fila de asientos se ha desplegado.");
            }
        }

       

    }
}
