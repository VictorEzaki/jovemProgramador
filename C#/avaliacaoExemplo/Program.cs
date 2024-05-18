namespace Programa
{
    public class Program
    {
        static void Main()
        {
            int op = 0;

            do
            {
                Console.WriteLine("--------- Bem-Vindo ---------");
                Console.WriteLine("[1] Criar uma pessoa");
                Console.WriteLine("[2] Listar as pessoas");
                Console.WriteLine("[3] Alterar uma pessoa");
                Console.WriteLine("[4] Deletar uma pessoa");
                Console.WriteLine("[5] Sair do programa");
                Console.WriteLine("-----------------------------");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        PessoaView.CriarPessoa();
                        break;

                    case 2:
                        PessoaView.ListarPessoas();
                        break;

                    case 3:
                        PessoaView.AlterarPessoa();
                        break;

                    case 4:
                        PessoaView.DeletarPessoa();
                        break;

                    case 5:
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Opcação inválida!");
                        break;
                }
            } while (op != 5);
        }

        // static void CriarPessoa()
        // {
        //     Pessoa pessoa = new();

        //     Console.WriteLine("-------- Criando pessoa --------");
        //     Console.Write("Digite o nome: ");
        //     pessoa.Nome = Console.ReadLine() ?? "";
        //     Console.Write("Digite a idade: ");
        //     pessoa.Idade = Convert.ToInt32(Console.ReadLine());
        //     Console.Write("Digite o CPF: ");
        //     pessoa.Cpf = Console.ReadLine() ?? "";

        //     pessoas.Add(pessoa);
        // }
        // static void ListarPessoas()
        // {
        //     Console.WriteLine("-------- Nomes --------");
        //     if (pessoas.Count > 0)
        //     {
        //         foreach (Pessoa pessoa in pessoas)
        //         {
        //             Console.WriteLine((pessoas.IndexOf(pessoa)+1) + $"º {pessoa.Nome} - {pessoa.Idade} - {pessoa.Cpf}");
        //         }
        //     }
        //     else
        //     {
        //         Console.WriteLine("Lista de pessoas está vazia ainda.");
        //     }
        //     Console.WriteLine("-----------------------");
        // }
        // static void AlterarPessoa()
        // {
        //     // ListarPessoas();
        //     Console.WriteLine("---- Alterando uma pessoa ----");
        //     Console.WriteLine("Informe o indice da peassoa: ");
        //     int indice = Convert.ToInt32(Console.ReadLine()) - 1;
           
            // if (indice >= 0 && indice < pessoas.Count)
            // {
            //     Pessoa pessoa = pessoas[indice];

            //     Console.Write("Digite o nome para alterar: ");
            //     pessoa.Nome = Console.ReadLine() ?? "";
            //     Console.Write("Digite o idade para alterar: ");
            //     pessoa.Idade = Convert.ToInt32(Console.ReadLine());
            //     Console.Write("Digite o CPF para alterar: ");
            //     pessoa.Cpf = Console.ReadLine() ?? "";

            //     pessoas[indice] = pessoa;
            //     Console.WriteLine("Nome alterado com sucesso");
            // }
            // else
            // {
            //     Console.WriteLine("Indice inváldo!");
            // }
        // }
        // static void DeletarPessoa()
        // {
        //     // ListarPessoas();
        //     Console.WriteLine("---- Deletando uma pessoa ----");
        //     Console.WriteLine("Informe o indice da peassoa: ");
        //     int indice = Convert.ToInt32(Console.ReadLine()) - 1;
        //     if (indice >= 0 && indice < pessoas.Count)
        //     {
        //         pessoas.RemoveAt(indice);
        //     }
        //     else
        //     {
        //         Console.WriteLine("Indice inváldo!");
        //     }
        // }
    }
}