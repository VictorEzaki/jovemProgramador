#include <iostream>
#include <locale.h>
using namespace std;

main() {
	
	setlocale(LC_ALL, "portuguese");
	
	float ladoA, ladoB, ladoC, altura;
	
	cout << "Descobrindo se é triângulo ou não\n";
	cout << "--------------------------------------\n\n";
	
	cout << "Digite o primeiro lado: ";
	cin >> ladoA;
	cout << "Digite o segundo lado: ";
	cin >> ladoB;
	cout << "Digite o terceiro lado: ";
	cin >> ladoC;
	cout << "--------------------------------------\n\n";
	
	altura = (ladoA + ladoB + ladoC) / 2;
	
	if ((ladoA + ladoB) > ladoC && 
		(ladoA + ladoC) > ladoB && 
		(ladoB + ladoC) > ladoA) {
			cout << "Os lado passados formam um triângulo, e possui uma área de: " << (ladoA * altura) / 2;
		} else {
			cout << "Os lados passados não formam um triângulo.";
		}
	
}
