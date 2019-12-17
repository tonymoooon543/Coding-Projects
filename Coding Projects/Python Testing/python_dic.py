thisdict = {
    "brand": "Ford",
    "model": "Mustang",
    "year": 1964
}

thisdict["year"] = 2018

thisdict["color"] = "Green"

thisdict.pop("model")

thisdict2 = thisdict.copy()

for x, y in thisdict.items():
    print(x, y)

if "model" in thisdict:
    print("Yes, 'model is one of the values'")
else:
    print("No, 'model' is not one of the values")

print(len(thisdict))

for z, d in thisdict2.items():
    print(z, d)