namespace planta
{
    public class ApartView
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

            Console.Write("Em que andar você deseja morar? ");
            int andar = Convert.ToInt32(Console.ReadLine());

            ApartController.Cadastro(dono, numQuartos, numSuites, numBanheiros, andar);
        }
        public static void ListarAparts()
        {
            List<Apart> aparts = ApartController.ListarAparts();

            if (aparts.Count > 0)
            {
                foreach (Apart apart in aparts)
                {
                    Console.WriteLine($"------- {aparts.IndexOf(apart) + 1}º Apartamento -------");
                    Console.WriteLine(
                        "Dono: " + apart.Dono +
                        "\nNúmero de quartos: " + apart.NumQuartos +
                        "\nNúmero de banheiros: " + apart.NumBanheiros +
                        "\nNúmero de suítes: " + apart.NumSuites +
                        "\nAndar: " + apart.Andar
                        );
                    Console.WriteLine("------------------------------");
                }
            }
            else
            {
                Console.WriteLine("------- Apartamentos -------");
                Console.WriteLine("Lista de Apartamentos vazia!");
                Console.WriteLine("----------------------------");
            }

            ApartController.ListarAparts();
        }
        public static void AlterarApart()
        {
            List<Apart> aparts = ApartController.ListarAparts();

            ListarAparts();
            Console.WriteLine("Digite o indice do apartamento que deseja alterar: ");
            int indice = Convert.ToInt32(Console.ReadLine()) - 1;

            if (indice < aparts.Count && indice >= 0)
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

                Console.Write("Em que andar gostaria de morar? ");
                int andar = Convert.ToInt32(Console.ReadLine());

                ApartController.AlterarApart(indice, dono, numQuartos, numSuites, numBanheiros, andar);
            }
            else
            {
                Console.WriteLine("Indice inválido!");
            }
        }
    }
}