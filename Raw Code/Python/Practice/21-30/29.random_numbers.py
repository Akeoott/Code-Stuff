import random

x = random.randint(1,10) # randint = random intiger wich in this case is between 1 and 10
y = random.random() # Creates a random floating point

mylist = ["rock","paper","scissors"]
z = random.choice(mylist)

cards = [1,2,3,4,5,6,7,8,9,"J","Q","K","A"]

random.shuffle(cards)
cards = random.choice(cards)

print(x)
print(y)
print(z)
print(f"Your card is: {cards}")