#include <iostream>
#include <locale.h>
using namespace std;

main () {
	
	setlocale(LC_ALL, "portuguese");
	
	float raio, diametro, circunferencia, area;
	float pi = 3.14;
	
	cout << "Digite o valor do raio do círculo: ";
	cin >> raio;
	
	diametro = raio * 2;
	area = pi * (raio * raio);
	circunferencia = 2 * pi * raio;
	
	cout << "O diâmetro do círculo é " << diametro;
	cout << "\nA circunferência do círculo é " << circunferencia;
	cout << "\nA área do círculo é " << area;
	
}
