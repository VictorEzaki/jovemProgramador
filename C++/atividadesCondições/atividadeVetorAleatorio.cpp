#include <iostream>
#include <locale.h>
#include <cstdlib>
#include <ctime>

using namespace std;

main() {
	
	setlocale(LC_ALL, "portuguese");
	
	int array[15];
	
	unsigned seed = time(0);	
	srand(seed);
	
	for (int i = 0; i < 15; i++) {
		
		array[i] = rand()%100;
		cout << array[i] << "\n";
		
	}
	
	
}
