import os
import re
import shlex
import time

with open('a.piss', 'r') as data:
  a = shlex.split(data.read().replace('\n',' '))
ints = []
strings = []
fur = ""

science = ""
i = 0
j = 0
while i < len(a):
  #checks file type (for incovenience)
  if a[i] == "#specify":
    match a[i+1]:
      case "piss":
        i+=1
      case _:
        raise Exception(f"tf is this specification: \"{a[i]} {a[i+1]}\"")
  
  #checks functions
  if a[i] == "func":
    match a[i+1]:
      case "main(){":
          if "}" in a:
            pass
          else:
            raise Exception("where funny bracket?")
  
  #variables
  match a[i]:
    case "int":
      match a[i+2]:
        case "=":
          if a[i+1] not in ints and a[i+1] not in strings:
            ints.append(a[i+1])
            science = a[i+3]
            if len(ints) > 3:
              while j < len(ints)-1:
                science = science.replace(str(ints[j]),str(ints[j+1]))
                
                j+=2
              ints.append(eval(science))
              j=0
            else:
               ints.append(eval(a[i+3]))
          else:
            raise Exception(f"variable {a[i+1]} already exists, you idiot")
        case _:
          raise Exception(f"wtf: {a[i]} {a[i+1]}")
    case "string":
      match a[i+2]:
        case "=":
          if a[i+1] not in strings and a[i+1] not in ints:
            strings.append(a[i+1])
            strings.append(a[i+3])
          else:
            raise Exception(f"variable {a[i+1]} already exists, you idiot")
        case _:
          raise Exception(f"wtf: {a[i]} {a[i+1]}")
  
  #console functions
  match re.sub(r"\(.*?\)", "()", a[i]):
    case "c.typedown()":
      #Writes down a number/string
      fur = a[i].replace("c.typedown(","")
      if fur[:-1] in ints:
        print(ints[ints.index(fur[:-1])+1])
      elif fur[:-1] in strings and fur[0] != "&":
        print(strings[strings.index(fur[:-1])+1])
      elif fur[0] == "&":
        print(fur[:-1].replace('&',""))
      elif fur[:-1] == "":
        print("")
      else:
        while j < len(ints):
          fur = fur.replace(str(ints[j]),str(ints[j+1]))
          j+=2
        try:
          print(eval(fur[:-1]))
          j = 0
        except Exception:
          print(f"where tf is \"{fur[:-1]}\"")
    case "c.wait()":
      #pauses the script
      fur = a[i].replace("c.wait(","")
      if fur[:-1] in ints:
        time.sleep(ints[ints.index(fur[:-1])+1])
      else:
        time.sleep(int(fur[:-1]))
    case "c.intmemory()":
      fur = a[i].replace("c.intmemory(","")
      if fur[:-1] == "":
        print(f"{ints}")
      elif fur[:-1] in ints:
        print(f"['{ints[ints.index(fur[:-1])]}', {ints[ints.index(fur[:-1])+1]}]")
      else:
        try:
          print(f"['{ints[eval(fur[:-1])*2]}', {ints[(eval(fur[:-1]))*2+1]}]")
        except Exception:
          print(f"where tf is \"{fur[:-1]}\"")
    case "c.strmemory()":
      fur = a[i].replace("c.strmemory(","")
      if fur[:-1] == "":
        print(f"{strings}")
      elif fur[:-1] in strings:
        print(f"['{strings[strings.index(fur[:-1])]}', '{strings[strings.index(fur[:-1])+1]}']")
      else:
        try:
          print(f"['{strings[eval(fur[:-1])*2]}', '{strings[(eval(fur[:-1]))*2+1]}']")
        except Exception:
          print(f"where tf is \"{fur[:-1]}\"")
  i+=1