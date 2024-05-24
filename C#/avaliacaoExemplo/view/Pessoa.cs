namespace Programa
{
    public class PessoaView
    {
        public static void CriarPessoa()
        {
            Console.WriteLine("-------- Criando pessoa --------");
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine() ?? "";
            Console.Write("Digite a idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o CPF: ");
            string cpf = Console.ReadLine() ?? "";

            PessoaController.CriarPessoa(nome, idade, cpf);
        }
        public static void ListarPessoas()
        {
            Console.WriteLine("-------- Nomes --------");
            List<Pessoa> pessoas = PessoaController.ListarPessoa();
            Console.WriteLine("-----------------------");
        }

        public static void AlterarPessoa()
        {
            ListarPessoas();
            Console.WriteLine("---- Alterando uma pessoa ----");
            Console.WriteLine("Informe o indice da peassoa: ");
            int indice = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.Write("Digite o nome para alterar: ");
            string nome = Console.ReadLine() ?? "";
            Console.Write("Digite o idade para alterar: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o CPF para alterar: ");
            string cpf = Console.ReadLine() ?? "";

            PessoaController.AlterarPessoa(nome, idade, cpf, indice);
        }

        public static void DeletarPessoa()
        {           
            ListarPessoas();
            Console.WriteLine("---- Deletando uma pessoa ----");
            Console.WriteLine("Informe o indice da peassoa: ");
            int indice = Convert.ToInt32(Console.ReadLine()) - 1;
            PessoaController.DeletarPessoa(indice);
        }
    }
}