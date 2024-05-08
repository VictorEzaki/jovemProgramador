#include <iostream>
#include <locale.h>
using namespace std;

main() {
	
	setlocale(LC_ALL, "portuguese");

	float valorUnit[2], valorTotal, ipi;
	int qntdPeca[2], codPeca[2];
	
	cout << "Digite o valor do IPI: ";
	cin >> ipi;
	
	int function perguntas() {
		
		for (int i = 0; i < 2; i++) {
		system("cls");
		
		cout << "Digite o código da peça" << i+1 << ": ";
		cin >> codPeca[i];
		
		cout << "Digite o valor unitário da peça" << i+1 << ": ";
		cin >> valorUnit[i];
		
		cout << "Digite a quantidade de peças: ";
		cin >> qntdPeca[i];
		
		}
	} 
	
	system("cls");
	valorTotal = (valorUnit[0] * qntdPeca[0] + valorUnit[1] * qntdPeca[1]) * (ipi/100 + 1);
	
	cout << "O valor total do pedido é de: R$" << valorTotal;
	
}
