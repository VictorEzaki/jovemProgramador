namespace planta
{
    public class PlantaView
    {
        public static void MenuCsAp()
        {
            Console.WriteLine("[1] Casas");
            Console.WriteLine("[2] Apartamentos");
            Console.WriteLine("[3] Voltar");
        }
        public static void Cadastro()
        {
            int op = 0;

            do
            {
                Console.WriteLine("------ Cadastro ------");
                MenuCsAp();
                Console.WriteLine("----------------------");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        CasaView.Cadastro();
                        break;

                    case 2:
                        ApartView.Cadastro();
                        break;
                    case 3:
                        Console.WriteLine("Voltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            } while (op != 3);
        }
        public static void VerImovel()
        {
            int op = 0;

            do
            {
                Console.WriteLine("-------- Listar --------");
                MenuCsAp();
                Console.WriteLine("------------------------");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        CasaView.ListarCasas();
                        break;

                    case 2:
                        ApartView.ListarAparts();
                        break;
                    case 3:
                        Console.WriteLine("Voltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            } while (op != 3);
        }
        public static void AlterarImovel()
        {
            int op = 0;

            do
            {
                Console.WriteLine("-------- Alterar --------");
                MenuCsAp();
                Console.WriteLine("-------------------------");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        CasaView.AlterarCasa();
                        break;

                    case 2:
                        ApartView.AlterarApart();
                        break;
                    case 3:
                        Console.WriteLine("Voltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            } while (op != 3);
        }
        public static void DeletarImovel()
        {
            int op = 0;

            do
            {
                Console.WriteLine("------ Deletar ------");
                MenuCsAp();
                Console.WriteLine("---------------------");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        CasaView.Deletar();
                        break;

                    case 2:
                        // ApartView.Deletar();
                        break;
                    case 3:
                        Console.WriteLine("Voltando ao menu principal...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            } while (op != 3);
        }
    }
}