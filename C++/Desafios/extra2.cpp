#include <iostream>
#include <locale.h>
using namespace std;

main() {
	
	setlocale(LC_ALL, "portuguese");
	
	int num;
	
	cout << "Digite um número: ";
	cin >> num;
	
	cout << "O dobro do número escolhido é " << num * 2;
	
}
