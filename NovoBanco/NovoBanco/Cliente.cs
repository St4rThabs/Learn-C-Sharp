namespace NovoBanco
{
    public class Cliente
    {
        private string p;

        public Cliente(string p)
        {
            this.Nome = p;
        }

        public string Nome { get; private set; }
    }
}