namespace planta {
    public class Planta {
        public string Dono {get; set;}
        public int NumQuartos {get; set;}
        public int NumSuites {get; set;}
        public int NumBanheiros {get; set;}
        public int CasaOuAp {get; set;}
        public string Construtora {get; set;} = "JlleConstruções";
        
        public virtual void Construir()
        {
            Console.Write("Sua planta ja está sendo feita.\n");
        }
        public void InfoBasica()
        {
            Console.Write("Qual o seu nome? ");
            Dono = Console.ReadLine() ?? "";
            do
            {
                Console.WriteLine($"{Dono}, você deseja construir uma [1]casa ou [2]apartamento? obs.: Digite 1 ou 2: ");
                CasaOuAp = Convert.ToInt32(Console.ReadLine()); 
                Console.Write(CasaOuAp != 1 && CasaOuAp != 2 ? "Opção inválida": null);            
            } while(CasaOuAp != 1 && CasaOuAp != 2);
            Console.WriteLine("------------------------------------------------------------------------------");
        }
        public virtual void Coleta() 
        {
            Console.Write("Quantos quartos? ");
            NumQuartos = Convert.ToInt32(Console.ReadLine());

            Console.Write("Quantas suítes? ");
            NumSuites = Convert.ToInt32(Console.ReadLine());

            Console.Write("Quantos banheiros? ");
            NumBanheiros = Convert.ToInt32(Console.ReadLine());
        }
    }
}