using System.Diagnostics;

namespace Avaliacao
{
    public class ViewTarefas
    {
        public static void CriarTarefa()
        {
            Console.WriteLine("----- Criando uma tarefa -----");

            Console.Write("Digite o nome da tarefa: ");
            string nome = Console.ReadLine() ?? "";
            Console.Write("Digite a data limite desta tarefa (dd/mm/aaaa): ");
            string data = Console.ReadLine() ?? "";
            Console.Write("Digite a hora de entrega da tarefa (hh/mm): ");
            string hora = Console.ReadLine() ?? "";
            bool situacao = false;

            Console.WriteLine("------------------------------");

            ControllerTarefas.CriarTarefa(nome, data, hora, situacao);
            Console.WriteLine("Tarefa criada com sucesso!");
        }

        public static void ListarTarefas()
        {
            Console.WriteLine("----------------------- Tarefas -----------------------");
            List<Tarefas> tarefas = ControllerTarefas.ListarTarefas();
            string situacao;

            if (tarefas.Count > 0)
            {
                foreach (Tarefas tarefa in tarefas)
                {
                    situacao = tarefa.Situacao == false ? "Não concluída" : "Concluída";
                    Console.WriteLine(tarefas.IndexOf(tarefa) + 1 + $"º {tarefa.Nome} - {tarefa.Data} - {tarefa.Hora} - {situacao}");
                }
            }
            else
            {
                Console.WriteLine("Lista de tarefas está vazia ainda.");
            }
            Console.WriteLine("-------------------------------------------------------");
        }

        public static void AlterarTarefa()
        {
            ListarTarefas();
            Console.WriteLine("---- Alterando uma tarefa ----");
            Console.Write("Informe o indice da tarefa: ");
            int indice = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.Write("Digite o nome para alterar: ");
            string nome = Console.ReadLine() ?? "";
            Console.Write("Digite a data para alterar: ");
            string data = Console.ReadLine() ?? "";
            Console.Write("Digite a hora para alterar: ");
            string hora = Console.ReadLine() ?? "";
            Console.WriteLine("------------------------------");

            ControllerTarefas.AlterarTarefa(nome, data, hora, indice);
        }

        public static void DeletarTarefa()
        {
            ListarTarefas();

            Console.WriteLine("------- Deletando tarefas -------");
            Console.Write("Digite o indice da tarefa que deseja deletar: ");
            int indice = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine("---------------------------------");

            ControllerTarefas.DeletarTarefa(indice);
        }

        public static void AlterarStatus()
        {
            int status = 0;
            ListarTarefas();

            Console.WriteLine("-------------------- Alterar status --------------------");
            Console.Write("Digite o indice da tarefa que deseja alterar o status: ");
            int indice = Convert.ToInt32(Console.ReadLine()) - 1;

            do
            {
                Console.WriteLine("Deseja concluir ou desconcluir a tarefa? ");
                Console.WriteLine("[1]Concluir");
                Console.WriteLine("[2]Desconcluir");
                status = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("--------------------------------------------------------");

                switch (status)
                {
                    case 1:
                        ControllerTarefas.AlterarStatus(indice, status);
                        break;

                    case 2:
                        ControllerTarefas.AlterarStatus(indice, status);
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (status == 2 && status == 1);
        }
    }
}