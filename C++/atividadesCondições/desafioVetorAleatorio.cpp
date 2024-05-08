#include <iostream>
#include <locale.h>
#include <cstdlib>
#include <ctime>

using namespace std;

main() {
	
	setlocale(LC_ALL, "portuguese");
	
	int array[5];
	
	unsigned seed = time(0);	
	srand(seed);
	
	array[0] = 1 + rand() % 8;
	array[1] = 9 + rand() % 8;
	array[2] = 17 + rand() % 6;
	array[3] = 23 + rand() % 6;
	array[4] = 24 + rand() % 6;
	
	for (int i = 0; i < 5; i++) {
		
		cout << array[i] << "\n";
		
	}	
	
}
