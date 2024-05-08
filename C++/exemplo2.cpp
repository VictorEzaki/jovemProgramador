#include <iostream> // Importa uma biblioteca para colocar coisas na tela
using namespace std; // Não esquecer - area de trabalho.

main() { // Não esquecer - Função principal

	system("chcp 65001"); // Define o conjunto de caracteres
	
	// cout é para exebir na tela
	// << é obrigat�rio para o cout
	// \n serve para pular linha dentro do cout
	// \t serve para tabular dentro do cout
	cout<<"\n \t Titulo é \n";
	
	cout<<"Este programa\n";
	cout<<"s� escreverá";
	cout<<"\ncoisas na tela";
	cout<<"\ne mais nada";
	
	int numero, numero2; // declarando uma variável do tipo inteiro
	//cout<<"\n"<<numero<<" batata\n"; // concatenando variável a um texto
	cout<<"Digite um número: ";
	cin>>numero;
	cout<<"Digite outro número: ";
	cin>>numero2;
	cout<<"O resultado da multiplicação é: "<<numero * numero2<<"\n\n";
	
	float numeroComVirgula, outroNumeroComVirgula; // pascalCase
	// float NumeroComVirgula;  // CamelCase
	// float numero_com_virgula; // snakeCase
	cout<<"\n\nDigite um número com virgula (usando .): ";
	cin>>numeroComVirgula;
	cout<<"\n\nDigite outro número com virgula (usando .): ";
	cin>>outroNumeroComVirgula;
	cout<<"\nA soma é:"<<numeroComVirgula + outroNumeroComVirgula;
	
	double numComVirg;
	cout<<"\n\nDigite um número com virgula (usando .): ";
	cin>>numComVirg;
	cout<<"Seu numero double é: "<<numComVirg;

	char caracter;
	// int numeroInteiro = 1;
	// exemplo do que não fazer (=
	// cout<<caracter+numeroInteiro;
	cout<<"Digite um caracter: ";
	cin>>caracter;
	cout<<"voce digitou: "<<caracter;
	
	bool boleano = true;
	bool outroBoleano = 0; 
	cout<<"Valor da variavel boleano é: "<<boleano;
	cout<<"\nValor da variavel outroBoleano é: "<<outroBoleano;
	
	
	
	
		
	
	
	
	
	
	
	
	
	
	
	

}
