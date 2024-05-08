#include <iostream>
#include <locale.h>
using namespace std;

main() {
	
	setlocale(LC_ALL, "portuguese");
	
	int num;
	
	cout << "Digite um número que deseja saber a tabuada de 0 a 10: ";
	cin >> num;
	
	cout << "TABUADA DO " << num;
	cout << "\n------------------------------\n\n";
	for (int i = 0; i < 11; i ++) {
		cout << num << " x " << i << " = " << num * i << "\n";
	}
	
}
