#include <stdio.h>
 
using namespace std;
 
int main() {
    int age, year, month, day;
    scanf("%d", &age);
    year = age/365;
    month = (age%365)/30;
    day = (age%365)%30;
    printf("%d ano(s)\n%d mes(es)\n%d dia(s)\n", year, month, day);
    return 0;
}