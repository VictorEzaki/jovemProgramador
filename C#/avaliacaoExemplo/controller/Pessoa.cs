using ListasPessoas;

namespace Programa
{
    public class PessoaController
    {
        public static void CriarPessoa(string nome, int idade, string cpf)
        {
            // Validar cpf, validar idade, validar nome
            new Pessoa(
                nome, 
                idade, 
                cpf
            );
        }

        public static List<Pessoa> ListarPessoa()
        {
            return Pessoa.ListarPessoa();
        }

        public static void AlterarPessoa(string nome, int idade, string cpf, int indice)
        {
            List<Pessoa> pessoas = ListarPessoa();
            if (indice >= 0 && indice < pessoas.Count)
            {
                Pessoa.AlterarPessoa(nome, idade, cpf, indice);
                Console.WriteLine("Nome alterado com sucesso");
            }
            else
            {
                Console.WriteLine("Indice inváldo!");
            }
        }

        public static void DeletarPessoa(int indice)
        {
            Pessoa.DeletarPessoa(indice);
        }
    }
}