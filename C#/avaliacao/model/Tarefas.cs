using ListTarefas;

namespace Avaliacao
{
    public class Tarefas
    {
        public string Nome {get; set;}
        public string Data {get; set;}
        public string Hora {get; set;}
        public bool Situacao{get; set;}

        public Tarefas(string nome, string data, string hora, bool situacao)
        {
            Nome = nome;
            Data = data;
            Hora = hora;
            Situacao = situacao;

            ListaTarefas.tarefas.Add(this);
        }

        public static List<Tarefas> ListarTarefas()
        {
            return ListaTarefas.tarefas;
        }

        public static void AlterarTarefa(string nome, string data, string hora, int indice)
        {
            ListaTarefas.tarefas[indice].Nome = nome;
            ListaTarefas.tarefas[indice].Data = data;
            ListaTarefas.tarefas[indice].Hora = hora;
        }

        public static void DeletarTarefa(int indice)
        {
            ListaTarefas.tarefas.RemoveAt(indice);
        }

        public static void AlterarStatus(int indice, bool situacao)
        {
            ListaTarefas.tarefas[indice].Situacao = situacao;
        }
    }
}