using ListaAp;

namespace planta {
    public class Apart : Planta {
        public int Andar {get; set;}

        public Apart (string dono, int numQuartos, int numSuites, int numBanheiros, int andar)
        {
            Dono = dono;
            NumQuartos = numQuartos;
            NumSuites = numSuites;
            NumBanheiros = numBanheiros;
            Andar = andar;

            ApartList.aparts.Add(this);
        }
        public static List<Apart> ListarAparts()
        {
            return ApartList.aparts;
        }
        public static void AlterarApart(int indice, string dono, int numQuartos, int numSuites, int numBanheiros, int andar)
        {
            Apart apart = ApartList.aparts[indice];

            apart.Dono = dono;
            apart.NumQuartos = numQuartos;
            apart.NumSuites = numSuites;
            apart.NumBanheiros = numBanheiros;
            apart.Andar = andar;

            ApartList.aparts[indice] = apart;
        }
    }
}