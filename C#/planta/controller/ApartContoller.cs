namespace planta
{
    public class ApartController
    {
        public static void Cadastro(string dono, int numQuartos, int numSuites, int numBanheiros, int andar)
        {
            new Apart (
                dono,
                numQuartos,
                numSuites,
                numBanheiros,
                andar
            );
        }
        public static List<Apart> ListarAparts()
        {
            return Apart.ListarAparts();
        }
        public static void AlterarApart(int indice, string dono, int numQuartos, int numSuites, int numBanheiros, int andar)
        {
            Apart.AlterarApart(indice, dono, numQuartos, numSuites, numBanheiros, andar);
        }
    }
}