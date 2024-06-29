using Model;
namespace Controller
{
    public class ControllerTarefas
    {
        public static void Cadastrar(string tarefa, string data, string hora, bool situacao)
        {
            new Tarefas(
                tarefa,
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

        public static void AlterarTarefa(string tarefa, string data, string hora, int indice)
        {
            Tarefas.AlterarTarefa(tarefa, data, hora, indice);
        }

        public static void DeletarTarefa(int indice)
        {
            Tarefas.DeletarTarefa(indice);
        }

        public static void AlterarStatus(int indice)
        {
            Tarefas.AlterarStatus(indice);
        }
    }
}