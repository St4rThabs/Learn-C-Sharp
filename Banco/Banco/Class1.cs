using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Conta
    {
        private int numero;
        private Cliente titular;
        private double saldo = 100.0;


        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }
        public int Numero { get; set; }

        public bool Saca(double valor)
        {
            if (this.Saldo >= valor)
            {
                if (this.Titular.Idade < 18 && valor > 200)
                {
                    return false;
                }
                else
                {
                    this.Saldo -= valor;
                    return true;
                }

                this.Saldo -= valor;
                return true;
            }

            return false;

        }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public void Transfere(double valor, Conta destino)
        {
            if (this.Saca(valor))
            {
                destino.Deposita(valor);
            }
        }
    }
}
