namespace Prova {
    public class Funcoes {
        public static void Case1() {
            Console.Clear();

            double km, metros = 1000, centimetros = 100000;
            
            Console.WriteLine("\n--------------------------------------------------------------------\n");
            Console.WriteLine("\tConversor de quilômetros para metros e centímetros");
            Console.WriteLine("\n--------------------------------------------------------------------\n");
            
            Console.WriteLine("Digite o valor que deseja converter: ");
            km = Convert.ToDouble(Console.ReadLine());
            
            metros *= km;
            Console.WriteLine(km + "KM em metros é " + metros + " m.\n");
            centimetros *= km;
            Console.WriteLine(km + "KM em centímetros é " + centimetros + " cm.");
            Console.WriteLine("\n--------------------------------------------------------------------\n");

        }

        public static void Case2() {
            Console.Clear();

            double a, b, c, baseT, altura;
            	
            Console.WriteLine("\n-----------------------------------------------------------\n");
            Console.WriteLine("\tVerificando se é um triângulo ou não");
            Console.WriteLine("\n-----------------------------------------------------------\n");

            Console.WriteLine("Digite a medida do lado A (em centímetros): ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a medida do lado B (em centímetros): ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a medida do lado C (em centímetros): ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            
            if (a + b > c && a + c > b && b + c > a) {
                Console.WriteLine("-----------------------------------------------------------\n");
                Console.WriteLine("Os valores informados formam um triângulo.\nSabendo disso, podemos calcular a sua área (em centímetros).\n");
                Console.WriteLine("-----------------------------------------------------------\n");
                
                Console.WriteLine("Digite a medida da base do triângulo (em centímetros): ");
                baseT = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Digite a medida de altura do triângulo (em centímetros): ");
                altura = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("A área desse triângulo é de: " + (baseT * altura / 2) + " cm.");
                
            } else {
                Console.WriteLine("Os valores informados não formam um triângulo.");
                Console.WriteLine("\nLado A: " + a + " cm.");
                Console.WriteLine("\nLado B: " + b + " cm.");
                Console.WriteLine("\nLado C: " + c + " cm.");
            }
            Console.WriteLine("\n-----------------------------------------------------------\n");

        }

        public static void Case3() {
            Console.Clear();
            	
            double[] valorUnit = new double[2];
            double valorTotal, ipi;
            int[] codPeca = new int[2], qntdPeca = new int[2];
            
            Console.WriteLine("Digite a percentagem do IPI: ");
            ipi = Convert.ToDouble(Console.ReadLine());
            
            for (int i = 0; i < 2; i++) {
                
                Console.Clear();
                
                Console.WriteLine("Digite o código da " + (i+1) + "º peça: ");
                codPeca[i] = Convert.ToInt16(Console.ReadLine());
                
                Console.WriteLine("Digite o valor unitário da " + (i+1) + "º peça: R$");
                valorUnit[i] = Convert.ToDouble(Console.ReadLine());
                
                Console.WriteLine("Digite o quantidade de peças: ");
                qntdPeca[i] = Convert.ToInt16(Console.ReadLine());
                
            }
            
            valorTotal = (valorUnit[0] * qntdPeca[0] + valorUnit[1] * qntdPeca[1]) * (ipi/100 + 1);
            
            Console.WriteLine("O valor total do pedido é de: R$" + valorTotal);
            Console.WriteLine("\n-----------------------------------------------------------\n");

        }

        public static void Case4() {

            Console.Clear();
            	
            int qntdPessoas;
            
            Console.WriteLine("\n-----------------------------------------------------------\n");
            Console.WriteLine("\tCalculando a média de altura das pessoas\n");
            Console.WriteLine("-----------------------------------------------------------\n");
            
            Console.WriteLine("Digite a quantidade de pessoas presentes: ");
            qntdPessoas = Convert.ToInt16(Console.ReadLine());
            
            Double[] altura = new double[qntdPessoas];
            double total = 0, media;
            
            for (int i = 0; i < qntdPessoas; i++) {
                
                Console.Clear();
                
                Console.WriteLine("Digite a altura da " + (i+1) + "º pessoa: ");
                altura[i] = Convert.ToDouble(Console.ReadLine());
                total += altura[i];
                
            } 

            media = total/qntdPessoas;
            
            Console.Clear();
            if (qntdPessoas > 0) {
                Console.WriteLine("A média de altura dessas pessoas é de: " + media + " m.");
            } else {
                Console.WriteLine("Não foi possível calcular a média pois tem 0 pessoas presentes.");
            }
            Console.WriteLine("\n-----------------------------------------------------------\n");
        }

        public static void Case5() {

            Console.Clear();
            	
            	double num;
				int[] multiplicador = new int[11] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
				
            	Console.WriteLine("\n-----------------------------------------------------------\n");
				Console.WriteLine("\tTabuada de 0 a 10");
				Console.WriteLine("\n-----------------------------------------------------------\n");
				Console.WriteLine("Digite um número: ");
				num = Convert.ToDouble(Console.ReadLine());
				Console.Clear();
				Console.WriteLine("\tTabuada do " + num);
            	Console.WriteLine("\n-----------------------------------------------------------\n");
				
				for (int i = 0; i < 11; i++) {
					
					Console.WriteLine(" " + num + " x " + multiplicador[i] + " = " + num * multiplicador[i] + "\n");
					
				}
            	Console.WriteLine("-----------------------------------------------------------\n");

        }
        public static void Case6() {

            Console.Clear();
            	
            	Console.WriteLine("\n-----------------------------------------------------------\n");
            	const int max = 2;
				string desenho = "";
			
				for (int i = 0; i <= max; i++) {
					
					for (int j = 0; j <= i; j++) {
						
						desenho += "*";
						
					}
					desenho += "\n";
					
					for (int j = 0; j <= i+1; j++) {
						
						desenho += "*";
						
					}
					desenho += "\n";
					
					for (int j = 0; j <= i; j++) {
						
						desenho += "*";
						
					}
					desenho += "\n";
				}
					
				Console.WriteLine(desenho);
            	
            	Console.WriteLine("\n-----------------------------------------------------------\n");

        }
    }
}