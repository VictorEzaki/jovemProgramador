using ListasPessoas;

namespace Programa
{
    public class Pessoa
    {
        public string Nome {get; set;}
        public int Idade {get; set;}
        public string Cpf {get; set;}

        public Pessoa(string nome, int idade, string cpf)
        {
            this.Nome = nome;
            Idade = idade;
            Cpf = cpf;

            PessoaList.pessoas.Add(this);
        }

        public static List<Pessoa> ListarPessoa()
        {
            return PessoaList.pessoas;
        }

        public static void AlterarPessoa(string nome, int idade, string cpf, int indice)
        {
            Pessoa pessoa = PessoaList.pessoas[indice];
            pessoa.Nome = nome;
            pessoa.Idade = idade;
            pessoa.Cpf = cpf;

            PessoaList.pessoas[indice] = pessoa;
        }

        public static void DeletarPessoa(int indice)
        {
            PessoaList.pessoas.RemoveAt(indice);
        }

        public void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome}, tenho {Idade} anos, portador do cpf: {Cpf}.");
        }
    }
}