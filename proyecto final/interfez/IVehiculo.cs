﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final.interfez
{
    internal interface IVehiculo
    {
        string Marca { get; set; }
        string Modelo { get; set; }
        string Color { get; set; }
        int Anio { get; set; }
        string Placa { get; set; }
        string Tipo { get; set; }
        int VelocidadMaxima { get; }
        int VelocidadActual { get; }

        void Bocina();
        void Acelerar(int cuanto);
        void Encender();
        void Apagar();
        void Frenar(int cuanto);

    }
}
