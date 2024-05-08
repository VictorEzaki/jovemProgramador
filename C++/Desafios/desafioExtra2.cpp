#include <iostream>
#include <locale.h>
using namespace std;

main() {
	
	setlocale(LC_ALL, "portuguese");
	
	int num;
	
	cout << "Digite um número para saber se ele é positivo ou negativo: ";
	cin >> num;
	
	if (num >= 0) {
		cout << "O número esolhido é positivo.";
	} else {
		cout << "O número esolhido é negativo.";
	}
	
}
