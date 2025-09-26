# convert user input to python via the "input" funktion

name = input("What is you name?: ")
age = int(input("How old are you?: ")) # input is str by default, convert to int or float to do math with it
height = float(input("How tall are you in cm?: "))

print("Hello "+name)
print("Your age is "+str(age)) # dont forget to convert the int into a str when printing
print("Your "+str(height)+"cm tall")
