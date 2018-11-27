#include <stdio.h>

using namespace std;

int main(){
    int even = 0, number;
    while(scanf("%d", &number) == 1){
        if(number % 2 == 0) even++;
    }
    printf("%d valores pares\n", even);
    return 0;
}