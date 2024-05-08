#include <iostream>
#include <locale.h>
#include "calculoIPI.cpp"
using namespace std;

main() {
	
	setlocale(LC_ALL, "portuguese");

	bool resp[8];
	int positivo = 0;
	
	perguntas();
	
	cout << "Responsa 1 para sim, e 0 para não.\n";
	cout << "-------------------------------------------------------------\n";
	cout << "Trocou mensagens com a vítima? ";
	cin >> resp[0];
	cout << "Esteve no local do crime? ";
	cin >> resp[1];
	cout << "É parente ou reside perto da vítima? ";
	cin >> resp[2];
	cout << "Devia algum valor para a vítima? ";
	cin >> resp[3];
	cout << "Trabalha ou trabalhou com a vítima? ";
	cin >> resp[4];
	cout << "Possui algum tipo de relacionamento amoroso com a vítima? ";
	cin >> resp[5];
	cout << "Ficou feliz pelo destino fatídico na vítima? ";
	cin >> resp[6];
	cout << "Possui algum tipo de arma de fogo? ";
	cin >> resp[7];
	
	for (int i = 0; i < 8; i++) {
		
		positivo += (resp[i] == true) ?  1 : 0;
		
	}
	
	system ("cls");
	
	if (positivo == 4) {
		cout << "Suspeito do crime";
	} else if (positivo > 4 && positivo < 8) {
		cout << "Possível criminoso";
	} else if (positivo == 8) {
		cout << "Assassino";
	} else {
		cout << "Inocente";
	}
	
}
