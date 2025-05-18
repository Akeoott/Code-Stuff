# nested loops =    The "inner loop" will finish all of it's iterations before
#                   finishing one iteration og the "outer loop"

while True:
    try:
        rows = int(input("How many rows?: "))
        columns = int(input("How many columns?: "))
        symbol = input("Enter a symbol to use: ")
    except ValueError:
        print("Invalid input!")
    else:
        break
    
for i in range(rows):
    for j in range(columns):
        print(symbol, end="") # Dont forget to use (, end="") otherwise it wont work as intended.
    print()

# Explenation,  outer loop =    i moved downward, each loop is a new row.
#               inner loop =    j moves sideways, filling each row with symbols.
#               print(symbol, end="") = Keeps printing on the same line instad of making a new one.
#               print() = Moves to the next row once inner loop finishes.