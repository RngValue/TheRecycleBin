// First Before Second Letter (https://edabit.com/challenge/DT2aPWpeZxy82GZon)
#include <stdio.h>
#include <string.h>

short int secondAppeared = 0;
short int returnValue = 0;

int firstBeforeSecond(char *str, char first, char second) {
    secondAppeared = 0;
    returnValue = 0;
	for (int i = 0; i < strlen(str); i++) {
        if (str[i] == second) secondAppeared = 1;

        if (str[i] == first && secondAppeared) { returnValue = 0; }
        else if (str[i] == first && !secondAppeared) { returnValue = 1; }
    }
    return returnValue;
}

int main(void) {
    printf("%d\n", firstBeforeSecond("a rabbit jumps joyfully", 'a', 'j'));
    printf("%d\n", firstBeforeSecond("knaves knew about waterfalls", 'k', 'w'));
    printf("%d\n", firstBeforeSecond("happy birthday", 'a', 'y'));
    printf("%d\n", firstBeforeSecond("precarious kangaroos", 'k', 'a'));
    return 0;
}