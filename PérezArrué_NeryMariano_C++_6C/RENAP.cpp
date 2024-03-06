#include <iostream>
#include <locale.h>
using namespace std;
int main(){
setlocale(LC_ALL, "spanish");
string nombre[50];
string vecindad[50];
int anioNac[50], mesNac[50], fechNac[50];
int anioAct, edad;


cout<<"Ingrese el año actual: "; cin>>anioAct; cout<<endl;


	for(int i=0; i<2; i++){
		cout<<"\nIngrese su nombre: "; cin>>nombre[i];
		cout<<"Ingrese su vecindad: "; cin>>vecindad[i];
		cout<<"Ingrese su año de nacimiento: "; cin>>anioNac[i];
		cout<<"Ingrese su mes de nacimiento: "; cin>>mesNac[i];
		cout<<"Ingrese su fecha de nacimiento: "; cin>>fechNac[i];
		
		
	}	
	
	for(int i=0; i<2; i++){
		cout<<"\n"<<nombre[i]<<endl;
		cout<<vecindad[i]<<endl;
		cout<<fechNac[i]<<"/"<<mesNac[i]<<"/"<<anioNac[i]<<endl;
		
		edad = anioAct - anioNac[i];
		
		if(edad > 18 ){
			cout<<"Es mayor de edad"<<endl;
		}else{
			cout<<"Es menor de edad"<<endl;
		}
	}
	
	return 0;
}
