#include <iostream>

using namespace std;

// Function
int goldenFreddy(int a) {
  int b = a * a;
  return b;
}

int main() {
  // Variables
  string stranger[] = {"pussy", "fuck", "piss"};
  char amIaCunt = 'y';

  // Crap
  cout << stranger[2] << " ";
  cout << goldenFreddy(5) << "\n";

  while (amIaCunt == 'y') {
    cout << "Are you a cunt? [y/n] > ";
    cin >> amIaCunt;

    if (amIaCunt == 'y') {
      cout << "\nok!\n";
    } else {
      cout << "\nwell, then fuck off!\n";
    }
  }
}
