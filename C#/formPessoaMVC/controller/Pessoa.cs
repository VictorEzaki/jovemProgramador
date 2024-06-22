using System.ComponentModel;
using Model;

namespace Controller
{
    public class PessoaController
    {
        public static void CriarPessoa(string nome, string cpf, string idade)
        {
            int anos = Convert.ToInt32(idade);
            // Validar cpf, validar idade, validar nome
            new Pessoa(
                nome, 
                cpf,
                anos 
            );
        }
        public static void Sincronizar()
        {
            Pessoa.Sincronizar();
        }

        public static List<Pessoa> ListarPessoa()
        {
            List<Pessoa> pessoas = Pessoa.ListarPessoa();
            
            return Pessoa.ListarPessoa();
        }

        public static void AlterarPessoa(string nome, string cpf, string idade, int indice)
        {
            List<Pessoa> pessoas = ListarPessoa();
            int anos = Convert.ToInt32(idade);

            Pessoa.AlterarPessoa(nome, anos, cpf, indice);
        }

        public static void DeletarPessoa(int indice)
        {
            Pessoa.DeletarPessoa(indice);
        }
    }
}