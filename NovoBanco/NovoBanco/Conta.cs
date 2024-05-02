using System;

namespace NovoBanco
{
    public class Conta
    {
        public Conta()
        {
        }

        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }

        public virtual void Deposita(double valorOperacao)
        {
            this.Saldo += valorOperacao;
        }

        public virtual void Saca(double valor)
        {
            if(valor <= this.Saldo)
            {
               this.Saldo -= valor;
            }
 
        }
    }
}