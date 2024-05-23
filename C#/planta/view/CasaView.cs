namespace planta
{
    public class CasaView
    {
        public static void Cadastro()
        {
            Console.Write("Qual o seu nome? ");
            string dono = Console.ReadLine() ?? "";

            Console.Write("Quantos quartos? ");
            int numQuartos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Quantas suítes? ");
            int numSuites = Convert.ToInt32(Console.ReadLine());

            Console.Write("Quantos banheiros? ");
            int numBanheiros = Convert.ToInt32(Console.ReadLine());

            Console.Write("Será necessária quantas vagas na garagem? ");
            int vagasGaragem = Convert.ToInt32(Console.ReadLine());

            CasaController.Cadastro(dono, numQuartos, numSuites, numBanheiros, vagasGaragem);
        }
        public static void ListarCasas()
        {
            List<Casa> casas = CasaController.ListarCasas();

            if (casas.Count > 0)
            {
                foreach (Casa casa in casas)
                {
                    Console.WriteLine($"------- {casas.IndexOf(casa) + 1}º Casa -------");
                    Console.WriteLine(
                        "Dono: " + casa.Dono +
                        "\nNúmero de quartos: " + casa.NumQuartos +
                        "\nNúmero de banheiros: " + casa.NumBanheiros +
                        "\nNúmero de suítes: " + casa.NumSuites +
                        "\nVagas na garagem: " + casa.VagasGaragem
                        );
                    Console.WriteLine("-----------------------");
                }
            }
            else
            {
                Console.WriteLine("------- Casas -------");
                Console.WriteLine("Lista de casas vazia!");
                Console.WriteLine("---------------------");
            }
        }
        public static void AlterarCasa()
        {
            List<Casa> casas = CasaController.ListarCasas();

            ListarCasas();
            Console.WriteLine("Digite o indice da casa que deseja alterar: ");
            int indice = Convert.ToInt32(Console.ReadLine()) - 1;

            if (indice < casas.Count && indice >= 0)
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Digite as novas informações de cadastro:");
                Console.WriteLine("--------------------------------------------");

                Console.Write("Qual o seu nome? ");
                string dono = Console.ReadLine() ?? "";

                Console.Write("Quantos quartos? ");
                int numQuartos = Convert.ToInt32(Console.ReadLine());

                Console.Write("Quantas suítes? ");
                int numSuites = Convert.ToInt32(Console.ReadLine());

                Console.Write("Quantos banheiros? ");
                int numBanheiros = Convert.ToInt32(Console.ReadLine());

                Console.Write("Será necessária quantas vagas na garagem? ");
                int vagasGaragem = Convert.ToInt32(Console.ReadLine());

                CasaController.AlterarCasa(indice, dono, numQuartos, numSuites, numBanheiros, vagasGaragem);
            }
            else
            {
                Console.WriteLine("Indice inválido!");
            }
        }
        public static void Deletar()
        {
            ListarCasas();
            Console.WriteLine("\t\tDeletando uma casa");
            Console.WriteLine("--------------------------------------------------");
            Console.Write("Digite o indice da tabela casas que deseja deletar: ");
            int indice = Convert.ToInt32(Console.ReadLine());

            CasaController.DeletarCasa(indice - 1);
        }
    }
}