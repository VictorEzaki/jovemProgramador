#include <iostream>
#include <locale.h>
using namespace std;

main() {
	
	setlocale(LC_ALL, "portuguese");
	
	float nota1, nota2, nota3, media;
	
	cout << "Calculando a média do aluno\n";
	cout << "----------------------------------\nn";
	
	cout << "Digite a primeira nota: ";
	cin >> nota1;
	cout << "Digite a segunda nota: ";
	cin >> nota2;
	cout << "Digite a terceira nota: ";
	cin >> nota3;
	
	media = (nota1 + nota2 + nota3) / 3;
	
	if (media < 5) {
		cout << "Sua média é " << media << "\nSituação: Reprovado.";
	} else if (media < 7) {
		cout << "Sua média é " << media << "\nSituação: Recuperação.";
	} else {
		cout << "Sua média é " << media << "\nSituação: Aprovado.";
	}
	
}
