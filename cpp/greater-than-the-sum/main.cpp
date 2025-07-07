//Greater Than the Sum? (https://edabit.com/challenge/uCxezzuDTdN7KaGCi)
#include <iostream>
#include <vector>

using std::cout;
using std::vector;

bool greater_than_sum(vector<int> numbers) {
    int sum = 0;
    for (int i = 1; i <= numbers.size(); i++) {
        sum += numbers[i-1];
        if (numbers[i] < sum) {
            return false;
            break;
        }
    }
    return true;
}

int main(void) {
    cout << greater_than_sum({2, 3, 7, 13, 28}) << "\n";
    cout << greater_than_sum({1, 2, 4, 6, 13}) << "\n";
    return 0;
}