namespace planta
{
    public class CasaController
    {
        public static void Cadastro(string dono, int numQuartos, int numSuites, int numBanheiros, int vagasGaragem)
        {
            new Casa(
                dono,
                numQuartos,
                numSuites,
                numBanheiros,
                vagasGaragem
                );
        }
        public static List<Casa> ListarCasas()
        {
            return Casa.ListarCasas();
        }
        public static void AlterarCasa(int indice, string dono, int numQuartos, int numSuites, int numBanheiros, int vagasGaragem)
        {
            Casa.AlterarCasa (indice, dono, numQuartos, numSuites, numBanheiros, vagasGaragem);
        }
        public static void DeletarCasa(int indice)
        {
            List<Casa> casas = Casa.ListarCasas(); 
            if (indice >= casas.Count || indice < 0)
            {
                Console.WriteLine("Indice inválido!");
            }
            else
            {
                Casa.DeletarCasa(indice);
            }
        }
    }
}