using Model;
namespace Controller
{
    public class ControllerTarefas
    {
        public static void Cadastrar(string nome, string data, string hora, bool situacao)
        {
            new Tarefas (
                nome,
                data,
                hora,
                situacao
            );
        }

        public static void Sincronizar()
        {
            Tarefas.Sincronizar();
        }

        public static List<Tarefas> ListarTarefas()
        {
            return Tarefas.ListarTarefas();
        }

        public static void AlterarTarefa(string nome, string data, string hora, int indice)
        {
            Tarefas.AlterarTarefa(nome, data, hora, indice);
        }

        public static void DeletarTarefa(int indice)
        {
            Tarefas.DeletarTarefa(indice);
        }

        public static void AlterarStatus(int indice, int status)
        {
            List<Tarefas> tarefas = ListarTarefas();
            bool situacao;

            if(indice >= 0 && indice < tarefas.Count){
                situacao = status == 1 ? true : false; 
                
                Tarefas.AlterarStatus(indice, situacao);
                Console.WriteLine("Status alterado com sucesso!");
            } else {
                Console.WriteLine("Indice inválido");
            }
        }
    }
}