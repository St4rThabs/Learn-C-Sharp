namespace NovoBanco
{
    public class Cliente
    {
        private string nome;
        private int idade;
        private string cpf;

        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public string Nome { get; private set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }

    }
}