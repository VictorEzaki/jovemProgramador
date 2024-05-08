#include <iostream>
#include <locale.h>
using namespace std;

main () {
	
	setlocale(LC_ALL, "portuguese");
	
	float base, altura;
	
	cout << "CALCULANDO A BASE DE UM RETÂNGULO (em metros)\n";
	cout << "-------------------------------------\n\n";
	
	cout << "Digite o valor da base do retângulo: ";
	cin >> base;
	cout << "Digite o valor da altura do triângulo: ";
	cin >> altura;
	
	cout << "A área total desse retângulo é de " << base * altura << " m.";
	
}
