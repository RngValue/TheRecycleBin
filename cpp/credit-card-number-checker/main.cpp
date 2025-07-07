//Uses the Luhn algorithm to check wether a credit card number is valid or not
//source: https://www.groundlabs.com/blog/anatomy-of-a-credit-card/
//idea: https://www.reddit.com/r/youngpeopleyoutube/comments/15s074p/comment/jwc2321/?utm_source=share&utm_medium=web2x&context=3

#include <iostream>
#include <cmath>

using std::cout;

int sum;
int getSum(int n) {
    sum = 0;
    while (n != 0) {
        sum = sum + n % 10;
        n = n / 10;
    }
    return sum;
}

int finalNumber;
long long int a;
std::string credit_card_checker(long long int creditCardNumber) {
    finalNumber = 0;
    for (int i = 0; i <=16; i++) {
        a = floor(creditCardNumber/pow(10,i));
        if (i%2 != 0) finalNumber += getSum((a%10)*2);
        else finalNumber += getSum(a%10);
    }
    if (finalNumber%10 == 0) return "valid";
    else return "invalid";
}

int main(void) {
    cout << credit_card_checker(4417123456789113) << "\n";
    cout << credit_card_checker(1111111111111111) << "\n";
    cout << credit_card_checker(8888888888888888) << "\n";
    return 0;
}