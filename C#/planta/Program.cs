namespace planta {
    public class Program {
        public static void Main() 
        {
            Casa imovelC = new Casa();
            Apart imovelAp = new Apart();

            Console.WriteLine("\n\t\tSeja bem-vindo(a)\n");
            Console.WriteLine("Para prosseguirmos com a construção do seu imóvel, precisamos de algumas \ninformações para podermos fazer a planta do mesmo.");
            Console.WriteLine("------------------------------------------------------------------------------");

            imovelC.InfoBasica();

            switch (imovelC.CasaOuAp)
            {
                case 1:
                    imovelC.Coleta();
                    break;
                
                case 2:
                    imovelAp.Coleta();
                    break;
                
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}