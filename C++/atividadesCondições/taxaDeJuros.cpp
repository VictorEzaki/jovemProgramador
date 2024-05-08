#include <iostream>
#include <locale.h>
using namespace std;

main() {
	
	setlocale(LC_ALL, "portuguese");
	
	float capital = 0, taxa = 0;
	int tempo = 0;
	
	cout << "Calculando juros";
	cout << "\n------------------------------------------------\n";
	
	cout << "Informe o capital: R$";
	cin >> capital;
	
	cout << "Informe a taxa de juros (em decimal ex.: 0.05): ";
	cin >> taxa;
	
	cout << "Informe quantos dias a taxa agirá sob o capital: ";
	cin >> tempo;
	cout << "\n------------------------------------------------\n";
	
	cout << "O valor do montante é de: R$" << capital * taxa * tempo + capital;

}
