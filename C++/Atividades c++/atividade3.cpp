#include <iostream>
#include <locale.h>
using namespace std;

main() {
	
	setlocale(LC_ALL, "portuguese");
	
	float peso, pesoTotal;
	
	for ( int i = 0; i < 5; i ++) {
		cout << "Digite o peso da " << (i + 1) << "º pessoa: ";
		cin >> peso;
		pesoTotal += peso;
	}
	
	cout << "A média de peso entre essas 5 pessoas é: " << (pesoTotal / 5) << "KG.";
		
}
