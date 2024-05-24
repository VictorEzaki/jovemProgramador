using CasasList;

namespace planta {
    public class Casa : Planta {
        public int VagasGaragem {get; set;}

        public Casa(string dono, int numQuartos, int numSuites, int numBanheiros, int vagasGaragem)
        {
            Dono = dono;
            NumQuartos = numQuartos;
            NumSuites = numSuites;
            NumBanheiros = numBanheiros;
            VagasGaragem = vagasGaragem;

            CasasLista.casas.Add(this);
        }
        public static List<Casa> ListarCasas()
        {
            return CasasLista.casas;
        }
        public static void AlterarCasa(int indice, string dono, int numQuartos, int numSuites, int numBanheiros, int vagasGaragem)
        {
            Casa casa = CasasLista.casas[indice];
            
            casa.Dono = dono;
            casa.NumQuartos = numQuartos;
            casa.NumSuites = numSuites;
            casa.NumBanheiros = numBanheiros;
            casa.VagasGaragem = vagasGaragem;

            CasasLista.casas[indice] = casa;
        }
        public static void DeletarCasa(int indice)
        {
            CasasLista.casas.RemoveAt(indice);
        }
    }
}