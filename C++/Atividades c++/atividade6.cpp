#include <iostream>
#include <locale.h>
using namespace std;

main() {
	
	setlocale(LC_ALL, "portuguese");
	
	float tempo;
	
	cout << "Qual o tempo de duração do evento em segundos? ";
	cin >> tempo;
	
	cout << "\n\n-------------------------------------------\n\n";
	cout << "Duração do evento em horas: " << ((tempo / 60) / 60);
	cout << "\nDuração do evento em minutos: " << (tempo / 60);
	cout << "\nDuração do evento em segundos: " << tempo;
	
}
