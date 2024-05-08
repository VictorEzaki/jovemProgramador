#include <iostream>
#include <locale.h>
using namespace std;

main() {
	
	setlocale(LC_ALL, "portuguese");
	
	int num1, num2;
	
	cout << "Digite um número: ";
	cin >> num1;
	cout << "Digite outro número: ";
	cin >> num2;
	
	cout << "-------------------------------\n";
	
	if (num1 > num2) {
		cout << num1 << " é maior que " << num2;
	} else {
		cout << num2 << " é maior que " << num1;
	}
	
}
