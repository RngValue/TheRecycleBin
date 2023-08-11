for i in range(0,2147483647):
    with open("randomfile.txt", "a") as o:
        o.writelines(str(i)+str("/"))