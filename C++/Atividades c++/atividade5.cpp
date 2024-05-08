#include <iostream>
#include <locale.h>
using namespace std;

main () {
	
	setlocale (LC_ALL, "portuguese");
	
	float milhas;
	
	cout << "CONVERSOR DE MILHAS PARA QUILÔMETROS\n";
	cout << "-----------------------------------------\n\n";
	cout << "Digite a quantidade de milhas que deseja converter: ";
	cin >> milhas;
	
	cout << milhas << " milhas em KM é: " << (milhas * 1.60934) << "KM.";
	
}
