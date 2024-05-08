#include <iostream>
#include <locale.h>
using namespace std;

main() {
	
	setlocale(LC_ALL, "portuguese");

	float custoFabrica = 0, imposto = 0.45, distribuidor = 0.28;
	
	cout << "-------------------------------------------------------------------------\n";
	cout << "Calculando o valor final de um carro\n";
	cout << "-------------------------------------------------------------------------\n";
	cout << "Digite o custo de fábrica do carro: ";
	cin >> custoFabrica;
	
	imposto *= custoFabrica;
	distribuidor *= custoFabrica;
	
	cout << "Valor do imposto de 45% em cima do custo de fábrica do carro: R$" << imposto;
	cout << "\nPercentual do distribuidor em cima do custo de fábrica do carro: R$" << distribuidor;
	cout << "\n-------------------------------------------------------------------------\n";
	
	cout << "\nValor final do carro: R$" << custoFabrica + imposto + distribuidor;
	
}
