﻿using System;
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
        private int idade;

        public double Saldo  { get; set; }
        public Cliente Titular { get; set; }
        public int Numero { get; set; }
        public int Idade { get; set; }

        public bool Saca(double valor)
        {
            if (this.saldo >= valor)
            {
                if (this.idade < 18 && valor > 200)
                {
                    return false;
                }
                else
                {
                    this.saldo -= valor;
                    return true;
                }

                this.saldo -= valor;
                return true;
            }
            return false;

        }

        public void Deposita(double valor)
        {
            this.saldo += valor;
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
