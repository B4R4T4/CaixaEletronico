namespace CaixaEletronico
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string rg { get; set; }
        public string cpf { get; set; }
        public string endereco { get; set; }
        public int idade { get; set; }
        public bool EEmancipado { get; set; }

        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public Cliente() { }

        public bool EhMaiorDeIdade()
        {
            return this.idade >= 18;
        }

        public override string ToString()
        {
            return this.Nome;
        }

      



        public bool PodeAbrirContaSozinho()
        {
            var  maiordeIdade = (this.idade >= 18);
            var  emancipado = (this.EEmancipado);
            var temCpf = !string.IsNullOrEmpty(this.cpf);

            return (maiordeIdade || emancipado) && temCpf;

        }
    }

    
}