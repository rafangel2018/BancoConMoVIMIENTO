using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class CuentaCorriente :Cuenta
    {
        const decimal VALORCUPO = 100000;
        public decimal Cupo { get; set; }

        public CuentaCorriente(decimal saldo) : base(saldo)
        {
            Cupo = VALORCUPO;
        }
        public override string Consignar(decimal valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                Cupo += valor;
                RegistrarMovimientos(valor, "Consignar");
                return $"Se Consignó el valor {valor} su nuevo cupo es {Cupo} y su nuevo saldo es {Saldo}";
            }
            return $"Su Consignación no debe superar el valor utilizado de su cupo es: {Saldo}";
        }

        private void RegistrarMovimientos(decimal valor, string v)
        {
            throw new NotImplementedException();
        }

        public override string Retirar(decimal valor)
        {
            if (valor <= Cupo)
            {
                Saldo += valor;
                Cupo -= valor;
                RegistrarMovimientos(valor, "Retirar");
                return $"Se Retiro el valor {valor}  su cupo es {Cupo} y su nuevo saldo es {Saldo}";
            }
            return $"Su Retiro no debe superar el valor del cupo: {Saldo}";

        }
    }
}
