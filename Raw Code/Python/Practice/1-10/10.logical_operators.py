# logical operators (and,or,not) my favorite... = used to check if two or more conditional statements is true

temp = int(input("Whats the temperature outside?: "))

if temp >= 0 and temp <= 30:      # in order for this code to be true both conditions bust be true
    print("The temperature is good today.")
    print("Go outside and touch some grass you weeb!")
elif temp < 0 or temp > 30:         # as long as one statement is true the code will output true
    print("The temperature is bad today. I'an idiot so i cant tell if its too hot or cold since this is a or logical operation...")
    print("Stay inside or youll DIE!")

# The not condition will turn true to false and false to true

if not(temp >= 0 and temp <= 30):
    print("The temperature is bad today. I'an idiot so i cant tell if its too hot or cold since this is a or logical operation...")
    print("Stay inside or youll DIE!")
elif not(temp < 0 or temp > 30):
    print("The temperature is good today.")
    print("Go outside and touch some grass you weeb!")

# i switched the print statements so that the answer is still correct
