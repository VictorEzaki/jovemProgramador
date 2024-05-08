#include <iostream>
#include <locale.h>
using namespace std;

main () {
	
	setlocale (LC_ALL, "portuguese");
	
	int distancia;
	
	cout << "Conversão de KM para metros e centímetros: ";
	cin >> distancia;
	
	cout << "\n--------------------------------------\n\n";
	cout << distancia << " em metros é: " << (distancia * 1000) << "\n";
	cout << distancia << " em centímetros é: " << (distancia * 1000) * 100 << "\n";
	
}
