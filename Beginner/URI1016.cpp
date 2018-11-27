#include <stdio.h>

using namespace std;

int main(){
    int x;
    scanf("%d", &x);
    x /= ((90/(double)60) - (60/(double)60));
    printf("%d minutos\n", x);
    return 0;
}