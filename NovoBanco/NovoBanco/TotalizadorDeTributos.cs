using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoBanco
{
    class TotalizadorDeTributos
    {
        public double Total { get; private set; }

        //Usando polimorfismo com a interface ITributavel
        public void Acumula(ITributavel t)
        {
            Total += t.CalculaTributo();
        }
    }
}
