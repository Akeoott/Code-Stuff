# Loop Controll Statements = change a loops execution from its normal sequence

# break =      used to terminate the loop entirely
# continue =    skips to the next iteration of the loop.
# pass =        does nothing, acts as a placeholder

t = True
f = False

if t:
    while True:
        name = input("enter your name: ")
        if name != "": # "!=" is the opposite of "==" and just "" means a empty string.
            break # breaks out of the loop once something has been entered (cuz of the line above)

phone_number = "123-456-7890"

if f:
    for i in phone_number:
        if i == "-":
            continue # skips the specified character, in this case "-"
        print(i, end="")    # So its all in one line and not seperated.

if f:
    for i in range(1,21):
        if i == 13:
            pass # passes the specified character.
        else:
            print(i)
