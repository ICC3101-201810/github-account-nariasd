using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Registro
    {
        string cliente;
        string vehiculo;
        string sucursal;
        List<Accesorios> hola;
        DateTime inicioContrato;
        DateTime terminoContrato;
        int total;

        public Registro(string nombre, string auto, string sucursal1, List<Accesorios> accesorio , DateTime fechaInicio, DateTime fechaTermino, int dinero)
        {
            cliente = nombre;
            vehiculo = auto;
            sucursal = sucursal1;
            hola = accesorio;
            inicioContrato = fechaInicio;
            terminoContrato = fechaTermino;
            total = dinero; 
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
