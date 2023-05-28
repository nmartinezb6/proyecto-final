using System;
using static proyecto_final.clases.pickup;

class Program
{
    static void Main(string[] args)
    {
        PickUp miPickUp = new PickUp();
        miPickUp.Marca = "Toyota";
        miPickUp.Modelo = "Hilux";
        miPickUp.Color = "Rojo";
        miPickUp.Anio = 2022;
        miPickUp.Placa = "ABC123";
        miPickUp.Tipo = "Pick Up";
        miPickUp.VelocidadMaxima = 200;

        miPickUp.Encender();
        miPickUp.Acelerar(50);
        miPickUp.Bocina();
        miPickUp.Frenar(20);
        miPickUp.Apagar();
        miPickUp.ActivarTraccion4x4();

        Console.WriteLine("-----------------------------");

        Sedan miSedan = new Sedan();
        miSedan.Marca = "Honda";
        miSedan.Modelo = "Civic";
        miSedan.Color = "Gris";
        miSedan.Anio = 2021;
        miSedan.Placa = "DEF456";
        miSedan.Tipo = "Sedan";
        miSedan.VelocidadMaxima = 180;

        miSedan.Encender();
        miSedan.Acelerar(30);
        miSedan.Bocina();
        miSedan.Frenar(10);
        miSedan.AbrirTechoSolar();
        miSedan.Apagar();

        Console.WriteLine("-----------------------------");

        SUV miSUV = new SUV();
        miSUV.Marca = "Ford";
        miSUV.Modelo = "Explorer";
        miSUV.Color = "Negro";
        miSUV.Anio = 2020;
        miSUV.Placa = "GHI789";
        miSUV.Tipo = "SUV";
        miSUV.VelocidadMaxima = 220;

        miSUV.Encender();
        miSUV.Acelerar(40);
        miSUV.Bocina();
        miSUV.Frenar(15);
        miSUV.DesplegarTerceraFila();
        miSUV.Apagar();

        Console.ReadLine();
    }
}
