using Repository;

namespace Model
{
    public class Pessoa
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public string Cpf {get; set;}
        public int Idade {get; set;}

        public Pessoa()
        {

        }
        
        public static void Sincronizar()
        {
            PessoaList.Sincronizar();
        }

        public Pessoa(string nome, string cpf, int idade)
        {
            Nome = nome;
            Cpf = cpf;
            Idade = idade;

            PessoaList.Cadastrar(this);
        }

        public static List<Pessoa> ListarPessoa()
        {
            return PessoaList.pessoas;
        }

        public static void AlterarPessoa(string nome, int anos, string cpf, int indice)
        {
            PessoaList.Alterar(nome, cpf, anos, indice);
        }

        public static void DeletarPessoa(int indice)
        {
            PessoaList.Delete(indice);
        }

        public void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome}, tenho {Idade} anos, portador do cpf: {Cpf}.");
        }
    }
}