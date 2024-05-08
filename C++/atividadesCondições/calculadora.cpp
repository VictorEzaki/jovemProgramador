#include <iostream>
#include <locale.h>
using namespace std;

main() {
	
	setlocale(LC_ALL, "portuguese");
	
	float num1, num2;
	int operador;
	
	cout << "CALCULADORA SIMPLES\n";
	cout << "--------------------------------------------\n\n";
	
	cout << "Digite um número: ";
	cin >> num1;
	cout << "Digite outro número: ";
	cin >> num2;
	
	cout << "--------------------------------------------\n\n";
	cout << "Qual operação matemática deseja realizar?\n" <<
			"1)Para adição.\n" <<
			"2)Para subtração.\n" <<
			"3)Para divisão.\n" <<
			"4)Para multiplicação.";
	cin >> operador;
	
	cout << "--------------------------------------------\n\n";
	
	if (operador == 1) {
		cout << "O resultado da soma é: " << num1 + num2;
	} else if (operador == 2) {
		cout << "O resultado da subtração é: " << num1 - num2;
	} else if (operador == 3) {
		cout << "O resultado da divisão é: " << num1 / num2;
	} else if (operador == 4) {
		cout << "O resultado da divisão é: " << num1 * num2;
	} else {
		cout << "Opção inválida!";
	}
	
}
