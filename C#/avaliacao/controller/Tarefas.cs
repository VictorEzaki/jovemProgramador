namespace Avaliacao
{
    public class ControllerTarefas
    {
        public static void CriarTarefa(string nome, string data, string hora, bool situacao)
        {
            new Tarefas (
                nome,
                data,
                hora,
                situacao
            );
        }

        public static List<Tarefas> ListarTarefas()
        {
            return Tarefas.ListarTarefas();
        }

        public static void AlterarTarefa(string nome, string data, string hora, int indice)
        {
            List<Tarefas> tarefas = ListarTarefas();
            if (indice >= 0 && indice < tarefas.Count)
            {
                Tarefas.AlterarTarefa(nome, data, hora, indice);
                Console.WriteLine("Tarefa alterado com sucesso");
            }
            else
            {
                Console.WriteLine("Indice inváldo!");
            }
        }

        public static void DeletarTarefa(int indice)
        {
            List<Tarefas> tarefas = ListarTarefas();

            if(indice >= 0 && indice < tarefas.Count){
                Tarefas.DeletarTarefa(indice);
                Console.WriteLine("Tarefa deletada com sucesso!");
            } else {
                Console.WriteLine("Indice inválido");
            }
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