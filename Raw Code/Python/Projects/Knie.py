import time,sys
name, gay, alphabet= "", 0, "ABCDEFGHIJKLMNOPQR"

def slow_print(text, delay=0.1):
    for char in text:
        sys.stdout.write(char)
        sys.stdout.flush()
        time.sleep(delay)
    print()

while len(name) <= 2:
    print("You cant escape till you enter your name!")
    name = input("Enter your name: ").strip()
while gay == 0:
    try:
        gay = int(input("Are you gay? 1 = Yes, 2 = No: "))
    except ValueError:
        slow_print("You dont seem to be the brightest on this planet. (Enter a number)")
if gay == 1:
    slow_print("I know...")
elif gay == 2:
    slow_print("LIAR!!!")
else:
    slow_print("Hmm",0.2)
    slow_print("........",0.5)
    time.sleep(2)
    slow_print("DUDE!")
    time.sleep(1)
    slow_print(f"NO MATTER WHAT YOU SAY! YOUR GAY {name}")
    time.sleep(1)
    for letter in alphabet:
        print(letter)
        time.sleep(0.2)
    slow_print("SHUT UP! NO MATTER WHAT YOU SAY, THE FACT WILL NEVER CHANGE!")
