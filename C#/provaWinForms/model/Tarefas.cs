using Repo;

namespace Model
{
    public class Tarefas
    {
        public int Id { get; set; }
        public string Tarefa { get; set; }
        public string Data { get; set; }
        public string Hora { get; set; }
        public string Situacao { get; set; }

        public Tarefas()
        {

        }

        public Tarefas(string tarefa, string data, string hora, bool situacao)
        {
            Tarefa = tarefa;
            Data = data;
            Hora = hora;
            if (situacao == false)
            {
                Situacao = "Não concluída";
            }
            else
            {
                Situacao = "Concluída";
            }

            ListaTarefas.Cadastrar(this);
        }

        public static List<Tarefas> Sincronizar()
        {
            return ListaTarefas.Sincronizar();
        }

        public static List<Tarefas> ListarTarefas()
        {
            return ListaTarefas.ListarTarefas();
        }

        public static void AlterarTarefa(string tarefa, string data, string hora, int indice)
        {
            ListaTarefas.Alterar(tarefa, data, hora, indice);
        }

        public static void DeletarTarefa(int indice)
        {
            ListaTarefas.Delete(indice);
        }

        public static void AlterarStatus(int indice)
        {
            List<Tarefas> tarefas = ListarTarefas();
            string situacao = "";

            if (tarefas[indice].Situacao == "Não concluída")
            {
                situacao = "Concluída";
            }
            else
            {
                situacao = "Não concluída";
            }
            ListaTarefas.AlterarStatus(indice, situacao);
        }
    }
}