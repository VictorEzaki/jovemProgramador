namespace planta
{
    public class Program
    {
        static List<Casa> casas = new List<Casa>();
        static List<Apart> aparts = new List<Apart>();
        static void Main()
        {
            int op = 0;

            do
            {
                Console.WriteLine("---------- Bem-vindo ----------");
                Console.WriteLine("[1] Cadastrar planta de imóvel");
                Console.WriteLine("[2] Ver planta de imóveis cadastradas");
                Console.WriteLine("[3] Alterar planta de imóvel");
                Console.WriteLine("[4] Deletar planta de imóvel");
                Console.WriteLine("[5] Sair do programa");
                Console.WriteLine("-------------------------------");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        PlantaView.Cadastro();
                        break;

                    case 2:
                        PlantaView.VerImovel();
                        break;

                    case 3:
                        PlantaView.AlterarImovel();
                        break;

                    case 4:
                        PlantaView.DeletarImovel();
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

        // static void MenuCsAp()
        // {
        //     Console.WriteLine("[1] Casas");
        //     Console.WriteLine("[2] Apartamentos");
        //     Console.WriteLine("[3] Voltar");
        // }
        // static void Cadastro()
        // {
        //     int op = 0;

        //     do
        //     {
        //         Console.WriteLine("------ Cadastrar ------");
        //         MenuCsAp();
        //         Console.WriteLine("-----------------------");
        //         op = Convert.ToInt32(Console.ReadLine());

        //         switch (op)
        //         {
        //             case 1:
        //                 Casa casa = new Casa();
        //                 casa.Coleta();
        //                 casas.Add(casa);
        //                 break;

        //             case 2:
        //                 Apart apart = new Apart();
        //                 apart.Coleta();
        //                 aparts.Add(apart);
        //                 break;
        //             case 3:
        //                 Console.WriteLine("Voltando ao menu principal...");
        //                 break;
        //             default:
        //                 Console.WriteLine("Opção inválida");
        //                 break;
        //         }

        //     } while (op != 3);
        // }
        // static void VerImovel()
        // {
        //     int op = 0;
        //     int aux;

        //     do
        //     {
        //         Console.WriteLine("-------- Listar --------");
        //         MenuCsAp();
        //         Console.WriteLine("------------------------");
        //         op = Convert.ToInt32(Console.ReadLine());

        //         switch (op)
        //         {
        //             case 1:
        //                 aux = 1;
        //                 foreach (var casa in casas)
        //                 {
        //                     Console.WriteLine($"------- {aux}º Casa -------");
        //                     Console.WriteLine(
        //                         "Dono: " + casa.Dono +
        //                         "\nNúmero de quartos: " + casa.NumQuartos +
        //                         "\nNúmero de banheiros: " + casa.NumBanheiros +
        //                         "\nNúmero de suítes: " + casa.NumSuites +
        //                         "\nVagas na garagem: " + casa.VagasGaragem
        //                         );
        //                     Console.WriteLine("-----------------------");

        //                     aux++;
        //                 }
        //                 break;

        //             case 2:
        //                 aux = 1;
        //                 foreach (var apart in aparts)
        //                 {
        //                     Console.WriteLine($"------- {aux}º Casa -------");
        //                     Console.WriteLine(
        //                         "Dono: " + apart.Dono +
        //                         "\nAndar: " + apart.Andar +
        //                         "\nNúmero de quartos: " + apart.NumQuartos +
        //                         "\nNúmero de banheiros: " + apart.NumBanheiros +
        //                         "\nNúmero de suítes: " + apart.NumSuites
        //                         );
        //                     Console.WriteLine("-----------------------");

        //                     aux++;
        //                 }
        //                 break;
        //             case 3:
        //                 Console.WriteLine("Voltando ao menu principal...");
        //                 break;
        //             default:
        //                 Console.WriteLine("Opção inválida");
        //                 break;
        //         }

        //     } while (op != 3);
        // }
        // static void AlterarImovel()
        // {
        //     Console.WriteLine("------- Alterar -------");
        //     MenuCsAp();
        //     Console.WriteLine("-----------------------");
        // }
    }
}