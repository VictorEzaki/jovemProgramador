namespace Avaliacao
{
    public class Program
    {
        static void Main()
        {
            int op = 0;

            do
            {
                Console.WriteLine("--------- Bem-Vindo ---------");
                Console.WriteLine("[1] Criar uma tarefa");
                Console.WriteLine("[2] Listar as tarefas");
                Console.WriteLine("[3] Alterar uma tarefa");
                Console.WriteLine("[4] Deletar uma tarefa");
                Console.WriteLine("[5] Alterar status da tarefa");
                Console.WriteLine("[6] Sair do programa");
                Console.WriteLine("-----------------------------");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        ViewTarefas.CriarTarefa();
                        break;
                    case 2:
                        ViewTarefas.ListarTarefas();
                        break;
                    case 3:
                        ViewTarefas.AlterarTarefa();
                        break;
                    case 4:
                        ViewTarefas.DeletarTarefa();
                        break;

                    case 5:
                        ViewTarefas.AlterarStatus();
                        break;
                    case 6:
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (op != 6);
        }
    }
}