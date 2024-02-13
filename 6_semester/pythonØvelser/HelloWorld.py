# Exercise 1
# Hello world.
# Lav et program der skriver ”Hello World” ud ….Når en variabel du har indlæst er større end 3.
# Du skal køre dit program fra Pycharm, men også direkte fra cmd prompt

xd = 3


def hello_world(tal):
    if tal >= 3:
        print("Hello world")
        return
    print("input < 3")


hello_world(xd)
