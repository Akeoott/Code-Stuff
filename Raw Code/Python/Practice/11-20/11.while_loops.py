# while loop =  a statement that will execute it's block of code,
#               as long as it's condition remains true.

# This is one way to do it

name1 = ""

while len(name1) <= 2:
    print("You cant escape till you enter your name!")
    name1 = input("Enter your name: ").strip()
print(f"Hello {name1}")

# This is the other way

f = False
name2 = None

if f:  # Just there to skip this part when executing
    while not name2 or len(name2.strip()) <= 2:
        print("You cant escape till you enter your name!")
        name2 = input("Enter your name: ").strip()
else:
    print("Thanks for your time!")