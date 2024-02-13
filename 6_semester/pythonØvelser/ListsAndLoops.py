
# liste med forfattere
forfatterList = ["Abercrombie", "Sapkowski", "Sanderson", "Lee", "Bardugo"]

# omskriv index 0
forfatterList[0] = "Snowden"

# indsæt ny forfatter
forfatterList.append("Gwynne")

# fjern forfatter ved index 1
forfatterPop = forfatterList.pop(1)

for forfatter in forfatterList:
    print(forfatter)

print(f"Død forfatter: {forfatterPop}")


# længden af listen
length = len(forfatterList)

print(length)

# reverse
forfatterList.reverse()

print(forfatterList)

