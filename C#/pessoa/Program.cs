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
                        Cadastrar();
                        break;
                    case 2:
                        LerNomes();
                        break;
                    case 3:
                        Update();
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
        
        static void Cadastrar()
        {
            Console.Write("Digite um nome: ");
            string nome = Console.ReadLine() ?? "";
            itens.Add(nome);
            Console.WriteLine($"O nome: {nome}, foi cadastrado com sucesso.");
        }
        
        static void LerNomes()
        {
            foreach (string item in itens)
            {
                Console.WriteLine(item);
            }
            
            // FORMA MAIS SIMPLES 
            // itens.foreach(Console.WriteLine);

            // itens.foreach(item => {
            // console.WriteLine(item); 
            // })
        }

        static void Delete()
        {
            Console.Write("Informe o índice que deseja deletar: ");
            int indice = Convert.ToInt32(Console.ReadLine());

            itens.RemoveAt(indice);
        }

        static void Update()
        {

        }
    }
}