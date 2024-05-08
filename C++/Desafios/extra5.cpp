#include <iostream>
#include <locale.h>
using namespace std;

main() {
	
	setlocale(LC_ALL, "portuguese");
	
	int nota1, nota2, nota3;
	float media;
	
	cout << "CALCULANDO A MÉDIA DO ALUNO\n";
	cout << "-----------------------------------";
	
	cout << "\n\nDigite a primeira nota: ";
	cin >> nota1;
	cout << "Digite a segunda nota: ";
	cin >> nota2;
	cout << "Digite a terceira nota: ";
	cin >> nota3;
	media = ((nota1 * 2) + (nota2 * 3) + (nota3 * 5)) / 10;
	
	cout << "\n\nA média do aluno foi " << media;
	
}
