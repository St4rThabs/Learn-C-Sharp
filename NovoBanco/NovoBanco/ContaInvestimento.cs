using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoBanco
{
    public class ContaInvestimento : Conta, ITributavel
    {
        public override void Deposita(double valor)
        {
            //base.Saca(valor + 0.10);
            this.Saldo += valor;
        }

        public override void Saca(double valor)
        {
            //base.Saca(valor + 0.10);
            if (valor <= this.Saldo)
            {
                this.Saldo -= valor + 0.10;
            }
        }

        // Calcula Tributo faz parte da interface, logo é obritório implementar esse método
        public double CalculaTributo()
        {
            return this.Saldo * 0.03;
        }
    }
}
