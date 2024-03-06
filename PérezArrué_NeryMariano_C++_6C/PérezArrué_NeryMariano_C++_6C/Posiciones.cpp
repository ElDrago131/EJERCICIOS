#include <iostream>
using namespace std;
int main(){
int vector[10] = {-1,2,3,4,5,6,7,8,9,0};
	
	if(vector[4] > 0){
		cout<<"El valor de la posicion 5 es positiva";
	}	else {
		cout<<"El valor de la posicion 5 es negativa";
	}
	
	if(vector[0] < 0){
		cout<<"\nEl valor de la posicion 1 es negativa";
	}	else {
		cout<<"\nEl valor de la posicion 1 es positiva";
	}
	
	if(vector[9] == 0){
		cout<<"\nEl valor de la ultima posicion es 0";
	}	else {
		cout<<"\nEl valor de la ultima posicion no es 0";
	}
	
	
	return 0;
}
