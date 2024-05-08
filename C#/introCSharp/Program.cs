namespace Prova {
    public class Program {
        public static void Main (string[] args){

            int op;
    
            do{
                Console.WriteLine("\n \t Escolha uma opção a seguir: \n");
                Console.WriteLine("\n [1] Exercício 1");
                Console.WriteLine("\n [2] Exercício 2");
                Console.WriteLine("\n [3] Exercício 3");
                Console.WriteLine("\n [4] Exercício 4");
                Console.WriteLine("\n [5] Exercício 5");
                Console.WriteLine("\n [6] Use a sua criatividade");
                Console.WriteLine("\n [7] Encerrar \n");
                op = Convert.ToInt16(Console.ReadLine());
                switch(op) {
                    case 1: {
                        Funcoes.Case1();
                        break;
                    };
                    case 2: {
                        Funcoes.Case2();
                        break;
                    };
                    case 3: {
                        Funcoes.Case3();
                        break;
                    };
                    case 4: {
                        Funcoes.Case4();
                        break;
                    };
                    case 5: {
                        Funcoes.Case5();
                        break;
                    };
                    case 6: {
                        Funcoes.Case6();
                        break;
                    };
                    case 7: {
                        Console.WriteLine("Finalizando");
                        break;
                    };
                    default:
                        Console.WriteLine("\nOpção inválida");
                        break;
                }
            }while(op != 7);
            Console.WriteLine("\n\n\n\n\n - Até mais \n\n\n\n\n");

        }
    }
}