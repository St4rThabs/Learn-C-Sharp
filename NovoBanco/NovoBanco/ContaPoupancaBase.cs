namespace NovoBanco
{
    public class ContaPoupancaBase
    {
        public override void Saca(double valor)
        {

            this.Saldo -= (valor + 0.10);

        }
    }
}