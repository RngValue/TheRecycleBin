import requests
import pybase64
import json

def getInfo(call):
    r = requests.get(call)
    return r.json()

get_name = input("> ")
name = "https://api.mojang.com/users/profiles/minecraft/" + str(get_name)
data = getInfo(name)
name_link = "https://sessionserver.mojang.com/session/minecraft/profile/" + str(data["id"])

data = getInfo(name_link)

prVal = data["properties"][0]["value"]
dec = pybase64.b64decode(prVal)
more = json.loads(dec)
print(more["textures"]["SKIN"]["url"])
input("Exit?")