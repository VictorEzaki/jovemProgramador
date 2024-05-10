namespace objeto 
{
    public class Program 
    {
        static List<string> itens = new List<string>(); // ou somente []

        public static void Main() 
        {
            int op = 0;

            do
            {
                Console.WriteLine("1 - (C) Para cadastrar um nome.");
                Console.WriteLine("2 - (R) Para ler os nomes.");
                Console.WriteLine("3 - (U) Para atualizar os nomes.");
                Console.WriteLine("4 - (D) Para deletar um nome.");
                Console.WriteLine("5 - Para sair do programa.");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        CadastrarNome();
                        break;
                    case 2:
                        LerNomes();
                        break;
                    case 3:
                        AlterarNome();
                        break;
                    case 4:
                        Delete();
                        break;
                    case 5:
                        Console.WriteLine("Saindo do programa...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (op != 5);
        }
        
        static void CadastrarNome()
        {
            Console.Write("Digite um nome: ");
            string nome = Console.ReadLine() ?? "";
            itens.Add(nome);
            Console.WriteLine("----------------------------");
            Console.WriteLine($"O nome: {nome}, foi cadastrado com sucesso.");
            Console.WriteLine("----------------------------");
        }
        
        static void LerNomes()
        {
            // foreach (string item in itens)
            // {
            //     Console.WriteLine(item);
            // }
            
            // FORMA MAIS SIMPLES 
            // itens.foreach(Console.WriteLine);

            // itens.foreach(item => {
            // console.WriteLine(item); 
            // })

            if (itens.Count > 0)
            {
                Console.WriteLine("----------- Nomes ----------");
                itens.ForEach(Console.WriteLine);
                Console.WriteLine("----------------------------");
            }
            else
            {
                Console.WriteLine("----------- Nomes ----------");
                Console.WriteLine("Lista de nome está vazia.");
                Console.WriteLine("----------------------------");
            }
        }

        static void Delete()
        {
            Console.WriteLine("Informe o índice que deseja deletar: ");
            if (itens.Count > 0)
            {
                Console.WriteLine("----------- Nomes ----------");
                itens.ForEach(Console.WriteLine);
                Console.WriteLine("----------------------------");
            }
            else
            {
                Console.WriteLine("----------- Nomes ----------");
                Console.WriteLine("Lista de nome está vazia.");
                Console.WriteLine("----------------------------");
            }
            int indice = Convert.ToInt32(Console.ReadLine());

            if (indice >= 0 && indice < itens.Count)
            {
                string nmDel = itens[indice];
                itens.RemoveAt(indice);
                Console.WriteLine("----------------------------");
                Console.WriteLine($"Nome: {nmDel} foi deletado com sucesso!");
                Console.WriteLine("----------------------------");
            }
            else
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("Índice inválido!");
                Console.WriteLine("----------------------------");
            }
        }

        static void AlterarNome()
        {
            Console.Write("Informe o índice que deseja alterar: ");
            int indice = Convert.ToInt32(Console.ReadLine());

            if (indice >= 0 && indice < itens.Count)
            {
                Console.Write("Digite o novo nome: ");
                string novoNome = Console.ReadLine() ?? "";
                string nomeAntigo = itens[indice];
                itens[indice] = novoNome;
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine($"Nome alterado {nomeAntigo} para {novoNome} com sucesso!");
                Console.WriteLine("-------------------------------------------------");
            }
            else
            {
                Console.WriteLine("Índice inválido!");
            }
        }
    }
}