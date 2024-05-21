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
            List<Pessoa> pessoas = Pessoa.ListarPessoa();
            if (pessoas.Count > 0)
            {
                foreach (Pessoa pessoa in pessoas)
                {
                    Console.WriteLine(pessoas.IndexOf(pessoa)+1 + $"º {pessoa.Nome} - {pessoa.Idade} - {pessoa.Cpf}");
                }
            }
            else
            {
                Console.WriteLine("Lista de pessoas está vazia ainda.");
            }
            
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