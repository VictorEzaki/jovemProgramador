using Repository;
namespace Model
{
    public class Pessoa
    {
        public string Nome {get; set;}
        public int Idade {get; set;}
        public string Cpf {get; set;}

        public Pessoa(string nome, int anos, string cpf)
        {
            Nome = nome;
            Idade = anos;
            Cpf = cpf;
        }

        public static List<Pessoa> ListarPessoa()
        {
            return ListPessoa.pessoas;
        }
    }
}