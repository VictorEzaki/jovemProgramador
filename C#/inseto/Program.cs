namespace objInsetos {
    public class Program {
        public static void Main() 
        {
            int op = 0;

            Insetos insetos = new Insetos();

            do
            {
                Console.Write("Seja bem ao nosso banco de dados sobre insetos.");

                insetos.Sobre();
                op ++;

            }while(op != 1);
        }
    }
}