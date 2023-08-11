import requests

def getInfo(call):
    r = requests.get(call)
    return r.json()

NAME_INPUT = input("Name: ")

name = NAME_INPUT

API_KEY = ""

name_link = "https://api.hypixel.net/player?key="+str(API_KEY)+"&name="+str(name)

print("(https://api.hypixel.net/player?key=######&name="+str(name)+")")
data = getInfo(name_link)

print("Success: "+str(data["success"]))

if data["success"] == False:
    print(str(data["cause"])+". Try again later.")
if data["success"] == True:
    stats = data["player"]["stats"]
    
    print("[Bedwars stats]")
    if "Bedwars" not in stats:
        print(str(name)+" has not played Bedwars yet...")
    else:
        assert("no")
        bedwars = stats["Bedwars"]
        if "wins_bedwars" in bedwars:
            print("wins: "+str(bedwars["wins_bedwars"]))
        else:
            print("wins: 0")
        if "winstreak" in bedwars:
            print("winstreak: "+str(bedwars["winstreak"]))
        else:
            print("winstreak: 0")
        if "kills_bedwars" in bedwars:
            print("kills: "+str(bedwars["kills_bedwars"]))
        else:
            print("kills: 0")
        if "final_kills_bedwars" in bedwars:
            print("final kills: "+str(bedwars["final_kills_bedwars"]))
        else:
            print("final kills: 0")
        if "deaths_bedwars" in bedwars:
            print("deaths: "+str(bedwars["deaths_bedwars"]))
        else:
            print("deaths: 0")
input("exit?")