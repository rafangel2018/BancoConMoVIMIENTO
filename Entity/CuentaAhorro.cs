using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entity
{
     public class CuentaAhorro : Cuenta
    {
        const decimal TOPE = 10000;
        public CuentaAhorro(decimal saldo,string numero) : base(saldo,numero)
        {
            TipoCuenta = "Ahorro";
          

        }

       

        public override string Consignar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                return $"USTED CONSIGNO {valor} su saldo es {Saldo}";
            }
            return "NO SE PUEDEN CONSIGNAR VALOR POSITIVO";
        }
        

        public override string Retirar(decimal valor)
        {
            if ((Saldo-valor)>TOPE)
            {
                Saldo -= valor;
                return $"USTED RETIRO {valor} su saldo es {Saldo}";
            }
            return $"VALOR INSUFICIENTE,USTED DEBE DEJAR UN TOPE DE {TOPE} SU SALDO ACTUAL ES DE {Saldo}";

        }
    }
}
