namespace planta {
    public class Apart : Planta {
        public int Andar {get; set;}

        public override void Construir()
        {
            base.Construir();
            Console.WriteLine($"E a {Construtora}, estará responsável pela construção de sua casa, Com {NumQuartos} quartos, {NumSuites} suítes e {NumBanheiros} banheiros.");
        }
        public override void Coleta()
        {
            Console.Write("Em que andar Gostaria de morar? ");
            Andar = Convert.ToInt32(Console.ReadLine());
            base.Coleta();
            Console.WriteLine("------------------------------------------------------------------------------");
            
            Construir();
            Console.WriteLine("------------------------------------------------------------------------------");
        }
    }
}