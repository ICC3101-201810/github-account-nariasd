using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sucursal
    {
        string nombreSucursal;
        string calle;
        int numeroCalle;
        List<Registro> reg;

        public Sucursal(string nSucursal, string nombreCalle, int numero, List<Registro> registro)
        {
            nombreSucursal = nSucursal;
            calle = nombreCalle;
            numeroCalle = numero;
            reg = registro;
        }

    }
}
