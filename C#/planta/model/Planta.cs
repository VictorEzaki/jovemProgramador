namespace planta {
    public class Planta {
        public string Dono {get; set;} = "Sem dono";
        public int NumQuartos {get; set;}
        public int NumSuites {get; set;}
        public int NumBanheiros {get; set;}
        public int CasaOuAp {get; set;}
        public string Construtora {get; set;} = "JlleConstruções";
        
        // public virtual void Coleta() 
        // {
        //     Console.Write("Qual o seu nome? ");
        //     Dono = Console.ReadLine() ?? "";

        //     Console.Write("Quantos quartos? ");
        //     NumQuartos = Convert.ToInt32(Console.ReadLine());

        //     Console.Write("Quantas suítes? ");
        //     NumSuites = Convert.ToInt32(Console.ReadLine());

        //     Console.Write("Quantos banheiros? ");
        //     NumBanheiros = Convert.ToInt32(Console.ReadLine());
        // }
    }
}