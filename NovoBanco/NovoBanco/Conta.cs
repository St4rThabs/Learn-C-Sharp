using System;

namespace NovoBanco
{
    public abstract class Conta
    {
        private static int numeroDeContas = 0;

        public Conta()
        {
            Conta.numeroDeContas++;
            this.Numero = Conta.numeroDeContas;
        }
        
        public int Numero { get; set; }
        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }

        public static int ProximoNumero()
        {
            return numeroDeContas + 1;
        }

        public abstract void Deposita(double valor);
        /*{
         * 
            this.Saldo += valorOperacao;

        }*/

        public abstract void Saca(double valor);
        /*
        {
            
            if(valor <= this.Saldo)
            {
               this.Saldo -= valor;
            }
            
         }
        */
    }
}