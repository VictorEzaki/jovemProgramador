#include <iostream>
#include <locale.h>
using namespace std;

main() {
	
	setlocale(LC_ALL, "portuguese");
	
	int a, b, c;
	
	cout << "Trocando o valor das variáveis de posição\n";
	cout << "--------------------------------------------\n";
	cout << "\n\nDigite um valor para a A: ";
	cin >> a;
	cout << "\nDigite um valor para B: ";
	cin >> b;
	
	cout << "Antes da troca, A = " << a << " e B = " << b;
	cout << "\n------------------------------------------\n";
	
	c = a;
	a = b;
	b = c;
	
	cout << "Depois da troca, A = " << a << " e B = " << b;
	
}
