namespace Programa
{
    public class Pessoa
    {
        public string Nome {get; set;}
        public int Idade {get; set;}
        public string Cpf {get; set;}

        public void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome}, tenho {Idade} anos, portador do cpf: {Cpf}.");
        }
    }
}