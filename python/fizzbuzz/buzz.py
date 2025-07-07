a = {
    3: "fizz",
    5: "buzz",
}

for i in range(0, 100):
    result = ""
    for key, value in a.items():
        if i%key != 0: continue
        result += value
    print(result if result != "" else str(i))
