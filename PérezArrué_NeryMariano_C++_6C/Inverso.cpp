#include <iostream>
using namespace std;
int main() {
    int numero, numeroInvertido = 0, digito;

    cout << "Ingresa un numero: ";
    cin >> numero;
    
    while (numero != 0) {
        digito = numero % 10;
        numeroInvertido = numeroInvertido * 10 + digito;
        numero /= 10;
    }

    cout << "El numero invertido es: " << numeroInvertido << endl;

    return 0;
}


