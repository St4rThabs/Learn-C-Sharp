using System;

namespace NovoBanco.Contas

{
    public class ContaCorrente : Conta, ITributavel
    {
        private static int totalDeContas = 0;

        public ContaCorrente()
        {
            ContaCorrente.totalDeContas++;
        }
        public static int ProximaConta()
        {
            return totalDeContas++;
        }

        public override void Deposita(double valor)
        {
            if (valor < 0.0)
                throw new ArgumentException();
            else this.Saldo += valor + 0.10;
        }

        public override void Saca(double valor) // por se tratar de um método abastrato, precisa do override também
        {
            if (valor < 0.0)
            {
                throw new ArgumentException();
            }
            if (valor + 0.10 >= this.Saldo)
            {
                throw new SaldoInsuficienteException();
            } else
            {
                this.Saldo -= valor + 0.10;
            }
        }

        public double CalculaTributo()
        {
            return this.Saldo * 0.05;
        }
    }
}