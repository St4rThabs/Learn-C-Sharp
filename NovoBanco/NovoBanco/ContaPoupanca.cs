using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoBanco
{
    public class ContaPoupanca : Conta
    {
        public override void Saca(double valor)
        {
            this.Saldo -= (valor + 0.10);
        }
    }
}
