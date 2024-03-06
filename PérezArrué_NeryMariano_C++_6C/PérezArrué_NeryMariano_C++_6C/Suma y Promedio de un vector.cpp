#include <iostream>
using namespace std;
int main(){
int vector[10] = {1,2,3,4,5,6,7,8,9,10};
float suma, promedio;	
	
	for(int i=0; i<10; i++){
		suma+=vector[i];
	}
	
	cout<<"La suma total del vector es: "<<suma;
	promedio=suma/10;
	cout<<"\nEl promedio es: "<<promedio;
	cout<<"\nEl 25% del promedio es: "<<promedio*0.25;
	
	return 0;
}
