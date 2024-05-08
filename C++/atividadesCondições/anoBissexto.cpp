#include <iostream>
#include <locale.h>
using namespace std;

main() {
	
	setlocale(LC_ALL, "portuguese");
	
	int ano;
	
	cout << "Digite um ano para saber se ele é bissexto: ";
	cin >> ano;
	
	if (ano % 4 == 0) {
		cout << "O ano Digitado é bissexto!";
	} else {
		cout << "O ano digitado não é bissexto.";
	}
	
}
