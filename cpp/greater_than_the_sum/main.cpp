//Greater Than the Sum? (https://edabit.com/challenge/uCxezzuDTdN7KaGCi)
#include <iostream>

using std::cout;

bool greater_than_sum(int *numbers, int size) {
    int sum = 0;
    for (int i = 1; i <= size; i++) {
        sum += numbers[i-1];
        if (numbers[i] < sum) {
            return false;
            break;
        }
    }
    return true;
}

int main(void) {
    int a[] = {2, 3, 7, 13, 28};
    cout << greater_than_sum(a, 5) << "\n";
    int b[] = {1, 2, 4, 6, 13};
    cout << greater_than_sum(b, 5) << "\n";
    return 0;
}