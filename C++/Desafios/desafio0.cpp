#include <iostream>
#include <locale.h>
using namespace std;

main() {
	
	setlocale(LC_ALL, "portuguese");
	
	float ano; 
	int totalDias;
	
	cout << "PROGRAMA PARA SABER A IDADE EM MESES E DIAS\n";
	cout << "-----------------------------------------------------\n";
	
	cout << "Digite o ano que você nasceu: ";
	cin >> ano;
	
	for (int i = ano; i < 2024; i ++) {
		if ((i + 1) % 4 == 0) {
			totalDias += 366;
		} else {
			totalDias += 365;
		}
	}
	
	cout << "Idade em anos: " << 2024 - ano << " anos de vida.\n";
	cout << "Idade em meses: " << (2024 - ano) * 12 << " meses de vida.\n";
	cout << "Idade em dias: " << totalDias << " dias de vida.\n";
	
}
