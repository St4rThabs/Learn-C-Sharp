namespace NovoBanco
{
    public class ContaCorrente : Conta
    {
        public override void Deposita(double valor)
        {
            base.Deposita(valor + 0.10);
        }

        public override void Saca(double valor)
        {
            base.Saca(valor + 0.10);   
        }
    }
}