using ListTarefas;

namespace Model
{
    public class Tarefas
    {
        public int IdTarefas {get; set;}
        public string Nome {get; set;}
        public string Data {get; set;}
        public string Hora {get; set;}
        public bool Situacao{get; set;}

        public Tarefas()
        {
            
        }

        public Tarefas(string nome, string data, string hora, bool situacao)
        {
            Nome = nome;
            Data = data;
            Hora = hora;
            Situacao = situacao;

            ListaTarefas.Cadastrar(this);
        }

        public static void Sincronizar()
        {
            ListaTarefas.Sincronizar();
        }

        public static List<Tarefas> ListarTarefas()
        {
            return ListaTarefas.tarefas;
        }

        public static void AlterarTarefa(string nome, string data, string hora, int indice)
        {
           ListaTarefas.AlterarTarefa(nome, data, hora, indice);
        }

        public static void DeletarTarefa(int indice)
        {
            ListaTarefas.Delete(indice);
        }

        public static void AlterarStatus(int indice, bool situacao)
        {
            ListaTarefas.tarefas[indice].Situacao = situacao;
        }
    }
}