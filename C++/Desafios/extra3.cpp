#include <iostream>
#include <locale.h>
using namespace std;

main () {
	
	setlocale(LC_ALL, "portuguese");
	
	float base, altura;
	
	cout << "CALCULANDO A ÁREA DE UM TRIÂNGULO (em metros)";
	cout << "\n--------------------------------------\n\n";
	
	cout << "Digite o valor da base do triângulo: ";
	cin >> base;
	cout << "Digite o valor da altura do triângulo: ";
	cin >> altura;
	
	cout << "A área total do triângulo é de " << (base * altura) / 2 << " m.";
	
}
