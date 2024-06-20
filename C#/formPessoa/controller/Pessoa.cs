using Model;
namespace Controller
{
    public class ControllerPessoa
    {
        public static void Cadastrar(
            string nome, 
            string idade,
            string cpf
        )
        {
            int anos = Convert.ToInt32(idade);
            new Pessoa(
                nome,
                anos,
                cpf
            );
        }
        public static List<Pessoa> ListarPessoa()
        {
            return Pessoa.ListarPessoa();
        }
    }

}