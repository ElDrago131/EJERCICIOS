#include <iostream>
using namespace std;
int main(){
int vector[20];
	
	
	cout<<"Ingrese 20 numeros"<<endl;
	for(int i=0; i<20; i++){
		cout<<"Numero "<<i+1<<": "; cin>>vector[i];
	}	
	
	
	for(int i=0; i<20; i++){
		if(vector[i]%2 == 0){
			vector[i]+=1;
		} else {
			vector[i]-=2;	
		}
		
	}
	
	cout<<"\n\nResultados"<<endl;
	for(int i=0;i<20; ++i) {
        cout<<"Dato "<<i+1<<": "<<vector[i]<<endl;
    }

	
	return 0;
}
