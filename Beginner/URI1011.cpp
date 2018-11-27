#include <stdio.h>
#include <cmath>

using namespace std;

int main(){
    double r;
    scanf("%lf", &r);
    printf("VOLUME = %.3lf\n", (4/3.0) * 3.14159 * pow(r,3));
    return 0;
}