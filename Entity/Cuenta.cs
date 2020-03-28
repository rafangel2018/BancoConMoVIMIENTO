using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class Cuenta
    {
        public string Cliente { get; set; }
        public  string TipoCuenta { get; set; }
        public string NumeroCuenta { get; set; }
        public decimal Saldo { get; set; }
        public List<Movimiento> Movimientos { get; set; }




        public Cuenta (decimal saldo,string numero)
        {
            Saldo = saldo;
            NumeroCuenta = numero;
        }

        public abstract string Consignar (decimal valor);
        public abstract string Retirar(decimal valor);

        public override string ToString()
        {
            return $"Cliente {Cliente} Numero de cuenta{NumeroCuenta} Saldo{Saldo}";
        }

    }
}
