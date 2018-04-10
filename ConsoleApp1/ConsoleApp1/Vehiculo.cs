using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     public class Vehiculo
    {
        string tipo;
        string patente;
        string color;

        public Vehiculo(string tipoVehiculo, string Lapatente, string elcolor)
        {
            tipo = tipoVehiculo;
            patente = Lapatente;
            color = elcolor;

        }
    }
    public class camion : Vehiculo
    {
        public string Marca;
        public string Modelo;
        public int año;

        public camion(string tipo, string patente, string color, string Marca, string Modelo, string año)
            :base(tipo, patente, color)
        {
            Marca = laMarca;
            Modelo = elModelo;
            año = elAño;
        }

    }
    public class auto : Vehiculo
    {

    }
}
