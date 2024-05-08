namespace objInsetos {
    public class Insetos { 
        public Boolean Voar {get; set;}

        public virtual void Sobre() 
        {
            Console.WriteLine("Descrição sobre o inseto.");
        }
    }
}