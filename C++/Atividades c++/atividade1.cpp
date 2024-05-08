#include <iostream>
#include <locale.h>
using namespace std;

main () {
	
	setlocale(LC_ALL, "portuguese");
	
	float num1, num2;
	
	cout << "Digite um número real (usando .): ";
	cin >> num1;
	cout << "Digite outro número real (usando .): ";
	cin >> num2;
	
	cout << "O resultado da soma entre " << num1 << " + " << num2 << " é = " << (num1 + num2);
	
	
	
	
	
	
}
