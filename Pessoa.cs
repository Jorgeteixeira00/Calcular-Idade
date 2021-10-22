using System;

namespace pooCalculaIdade
{
    class Pessoa
    {
        private int _anoNascimento;
        public int anoNascimento { get { return this._anoNascimento; } set { this._anoNascimento = value; } }

        private string _nome;

        public string nome { get { return this._nome; } set { this._nome = value.ToUpper(); } }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome:{this.nome}");
            Console.WriteLine($"Ano de nascimento:{anoNascimento}");
            Console.WriteLine($"Idade:{this.CalcularIdade()} anos");
        }

        private int CalcularIdade()
        {
            DateTime date = DateTime.Now;
            int ano = date.Year;
            int idade = ano - this.anoNascimento;
            return idade;
        }
    }
}
