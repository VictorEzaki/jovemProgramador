#include <iostream>
#include <locale.h>
using namespace std;

main() {
	
	setlocale(LC_ALL, "portuguese");
	
	long long cpf;
	int numDependentes;
	float rendaMensal = 0, salarioMin = 1412, descontoDependentes = 0;
	
	cout << "Calculando o imposto de renda\n";
	cout << "---------------------------------------\n\n";
	
	cout << "Digite o seu CPF: ";
	cin >> cpf;
	cout << "Digite o número de dependentes que reside com você: ";
	cin >> numDependentes;
	cout << "Digite o valor da sua renda mensal: ";
	cin >> rendaMensal;
	cout << "---------------------------------------\n\n";
	system ("cls");
	
	descontoDependentes = rendaMensal * (numDependentes * 0.05);
	rendaMensal -= descontoDependentes;
	
	if (rendaMensal <= (salarioMin * 2)) {
		cout << " Você é isento do imposto de renda.\n Desconto por dependente: R$" << descontoDependentes;
	} else if (rendaMensal <= (salarioMin * 3)) {
		cout << " Você tem deve pagar R$" << (rendaMensal * 0.05) << " de imposto de Renda.\n Desconto por dependente: R$" << descontoDependentes << "\n Salario líquido: R$" << rendaMensal - rendaMensal * 0.05;
	} else if (rendaMensal <= (salarioMin * 5)) {
		cout << " Você tem deve pagar R$" << (rendaMensal * 0.10) << " de imposto de Renda.\n Desconto por dependente: R$" << descontoDependentes << "\n Salario líquido: R$" << rendaMensal - rendaMensal * 0.10;
	} else if (rendaMensal <= (salarioMin * 7)) {
		cout << " Você tem deve pagar R$" << (rendaMensal * 0.15) << " de imposto de Renda.\n Desconto por dependente: R$" << descontoDependentes << "\n Salario líquido: R$" << rendaMensal - rendaMensal * 0.15;
	} else {
		cout << " Você tem deve pagar R$" << (rendaMensal * 0.20) << " de imposto de Renda.\n Desconto por dependente: R$" << descontoDependentes << "\n Salario líquido: R$" << rendaMensal - rendaMensal * 0.20;
	}
	
}
