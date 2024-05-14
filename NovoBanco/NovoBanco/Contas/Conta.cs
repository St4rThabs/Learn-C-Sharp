using System;

namespace NovoBanco.Contas
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

        public override string ToString()
        {
            return char.ToUpper(this.Titular.Nome[0])+ this.Titular.Nome.Substring(1);
        }
    }
    public class SaldoInsuficienteException : Exception
    {
        // fazendo com que a classe SaldoInsuficienteException herde a classe Exception para que possamos usar ela nas classes filhas para tratação de erros
    }

}