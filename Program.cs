using System;

namespace pooCalculaIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calcular idade de uma pessoa");
            Pessoa pessoa = new();

            Console.Write("Digite seu nome:");
            pessoa.nome = Console.ReadLine();
            Console.Write("Ano de nascimento:");
            pessoa.anoNascimento = Convert.ToInt32(Console.ReadLine());

            pessoa.ExibirDados();
        }
    }
}
