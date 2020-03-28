using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensaje;
            Cuenta cuentaAhorro = new CuentaAhorro (10000,"23");
             mensaje = cuentaAhorro.Retirar(90000);
             Console.WriteLine();
             mensaje = cuentaAhorro.Consignar(90000);
            Console.WriteLine(mensaje);
            Console.ReadKey();
        }
    }
}
