#include <iostream>
#include <locale.h>
using namespace std;

main() {
	
	setlocale(LC_ALL, "portuguese");
	
	int num;
	
	for (int i = 0; i < 10; i ++) {
		num += (i + 1);
	} 
	
	cout << "A soma de 1 a 10 é: " << num;
	
}
