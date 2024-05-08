#include <iostream>
#include <locale.h>
using namespace std;

main() {
	
	setlocale(LC_ALL, "portuguese");
	
	int num;
	
	cout << "Digite um número para saber se ele é par ou ímpar: ";
	cin >> num;
	
	if (num % 2 == 0) {
		cout << "O número esolhido é par.";
	} else {
		cout << "O número escolhido é ímpar.";
	}
	
}
