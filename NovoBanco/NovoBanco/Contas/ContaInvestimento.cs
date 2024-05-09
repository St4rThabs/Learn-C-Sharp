using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoBanco.Contas
{
    public class ContaInvestimento : Conta, ITributavel
    {
        public override void Deposita(double valor)
        {
            //base.Saca(valor + 0.10);
            if (valor < 0.0)
                throw new ArgumentException();
            else this.Saldo += valor;
        }

        public override void Saca(double valor)
        {
            //base.Saca(valor + 0.10);
            if (valor < 0.0)
            {
                throw new ArgumentException();
            }
            if (valor + 0.10 >= this.Saldo)
            {
                throw new SaldoInsuficienteException();
            }
            else
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
