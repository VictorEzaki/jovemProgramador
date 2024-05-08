#include <iostream>
#include <locale.h>
using namespace std;

main() {
	
	setlocale(LC_ALL, "portuguese");
	
	char sexo;
	float altura, imc;

	cout << "Digite sua altura: ";
	cin >> altura;
	cout << "Sexo? m(para masculino) e f(para feminino).";
	cin >> sexo;
	
	if (sexo == 'm' || sexo == 'M') {
		imc = (72.7 * altura) - 58;
		cout << "O imc masculino é de " << imc << ".";
	} else if (sexo == 'f' || sexo == 'F') {
		imc = (62.1 * altura) - 44.7;
		cout << "O imc feminino é de " << imc << ".";
	} else {
		cout << "Você selecionou uma opção inválida!";
	}
	
}
