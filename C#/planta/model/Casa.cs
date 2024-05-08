namespace planta {
    public class Casa : Planta {
        public int VagasGaragem {get; set;}

        public override void Construir()
        {
            base.Construir();
            Console.WriteLine($"E a {Construtora}, estará responsável pela construção de sua casa, Com {NumQuartos} quartos, {NumSuites} suítes, {NumBanheiros} banheiros e uma garagem com {VagasGaragem} vagas.");
        }
        public override void Coleta()
        {
            base.Coleta();
            Console.Write("Será necessária quantas vagas na caragem? ");
            VagasGaragem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------------");

            Construir();
            Console.WriteLine("------------------------------------------------------------------------------");
        }
    }
}