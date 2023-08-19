wordCount = 0

try:
    userInput = input("Name as many words as you can: ")
except SyntaxError:
    userInput = None

if userInput:
    if userInput[0] != ' ':
        wordCount+=1

    for i in range(len(userInput)):
        if userInput[i] == ' ' and userInput[i+1] != ' ':
            wordCount+=1

    print(f"You were able to name {wordCount} words!\nGreat job!")
else:
    print("You named no words.")