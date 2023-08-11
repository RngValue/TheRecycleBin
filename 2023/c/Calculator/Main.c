#include <stdio.h>

int main(void) {
  char hm = 'y';
  float lfjkasd = 0;
  float b, c, d;
  char a;
  while (hm == 'y') {
    printf("Math operation [+ - * /]: ");
    scanf(" %c", &a);
    if (lfjkasd == 0) {
      printf("1st number: ");
      scanf("%f", &b);
      printf("2nd number: ");
      scanf("%f", &c);
      switch (a) {
      case '+':
        d = b + c;
        break;
      case '-':
        d = b - c;
        break;
      case '*':
        d = b * c;
        break;
      case '/':
        d = b / c;
        break;
      default:
        d = b + c;
        break;
      }
    } else {
      printf("Number: ");
      scanf("%f", &c);
      switch (a) {
      case '+':
        d += c;
        break;
      case '-':
        d -= c;
        break;
      case '*':
        d *= c;
        break;
      case '/':
        d /= c;
        break;
      default:
        d += c;
        break;
      }
    }
    lfjkasd = 1;
    printf("(%c%f) %f\n", a, c, d);
  }
  return 0;
}