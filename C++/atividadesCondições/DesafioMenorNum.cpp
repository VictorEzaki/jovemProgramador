#include <iostream>
#include <locale.h>
using namespace std;

main() {
	
	setlocale(LC_ALL, "portuguese");
	
	int num1, num2, num3;
	
	cout << "Digite o primeiro número: ";
	cin >> num1;
	cout << "Digite o segundo número: ";
	cin >> num2;
	cout << "Digite o terceiro número: ";
	cin >> num3;
	
	if (num1 < num2 && num1 < num3) {
		cout << "O primeiro número digitado é o menor: " << num1;
	} else if (num2 < num1 && num2 < num3) {
		cout << "O segundo número digitado é o menor: " << num2;
	} else {
		cout << "O terceiro número digitado é o menor: " << num3;
	}
	
}
