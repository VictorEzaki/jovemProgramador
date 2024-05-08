#include <iostream>
#include <locale.h>
using namespace std;

main() {
	
	setlocale(LC_ALL, "portuguese");
	
	float c;
	
	cout << "Conversor de graus celcius para farenheit";
	cout << "\n-------------------------------------------------\n\n";
	cout << "Digite o valor em graus celcius: ";
	cin >> c;
	
	cout << c << "°C em farenheit é: " << (9 * c + 160) / 5 << "°F.";
	
}
